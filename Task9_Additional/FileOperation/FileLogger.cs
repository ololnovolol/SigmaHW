﻿using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Task9_Additional
{
    internal class FileLogger : IDisposable
    {
        public string keyValid { get; private set; } = "Valid";
        public string keyInvalid { get; private set; } = "Invalid";
        public string keyMaybe { get; private set; } = "Maybe";
        public Dictionary<string, List<string>> result { get; private set; }
        private readonly FileReader fReader;
        private readonly FileWriter fWriter;

        public FileLogger()
        {
            result = new Dictionary<string, List<string>>()
            {
                { keyValid, new List<string>()},
                { keyInvalid, new List<string>()}
            };
            fReader = new FileReader();
            fWriter = new FileWriter();
        }

        ~FileLogger()
        {
            fWriter.Dispose();
            fWriter.Dispose();
            Dispose();
        }

        public void Dispose()
        {
            fWriter.Dispose();
            fWriter.Dispose();
        }

        private void Add(string key, string value)
        {
            if (this.result.ContainsKey(key))
            {
                List<string> list = this.result[key];
                if (list.Contains(value) == false)
                {
                    list.Add(value);
                }
            }
            else
            {
                List<string> list = new List<string>();
                list.Add(value);
                this.result.Add(key, list);
            }
        }

        public void WriteToFile(string text)
        {
            fWriter.WriteToFile(text, true);
        }

        public List<string> ReadIp()
        {
            string[] lines = fReader.ReadFileLine("ListIp.txt", 0);

            if (lines.Length == 0 & lines == null) return new List<string>();

            List<string> result = new List<string>();
            result.AddRange(lines);

            return result;
        }

        public Dictionary<string, List<string>> ParseIp()
        {
            List<string> lines = ReadIp();

            foreach (var item in lines)
            {
                if (IsValidEmail(item))
                {
                    Add(keyValid, item);
                    continue;
                }
                if (ValidateEmailMaybe(item))
                {
                    Add(keyMaybe, item);
                    continue;
                }
                else
                {
                    Add(keyInvalid, item);
                }
            }


            return result;
        }

        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool ValidateEmailMaybe(string email)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (match.Success)
                return true;
            else
                return false;
        }
    }
}

