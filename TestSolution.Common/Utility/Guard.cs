using System;
using System.Xml;

namespace TestSolution.Common.Utility
{
    public static class Guard
    {
        public static void AgainstInvalidId(long id, string nameOfId)
        {
            if (id <= 0)
            {
                throw new ArgumentException($"Argument {nameOfId} must be a positive number.");
            }
        }

        public static void AgainstInvalidId(int id, string nameOfId)
        {
            if (id <= 0)
            {
                throw new ArgumentException($"Argument {nameOfId} must be a positive number.");
            }
        }

        public static void AgainstNegativeValue(decimal value, string nameOfValue)
        {
            if (value < 0)
            {
                throw new ArgumentException($"Argument {nameOfValue} must be a non-negative number.");
            }
        }

        public static void AgainstNegativeValue(short value, string nameOfValue)
        {
            if (value < 0)
            {
                throw new ArgumentException($"Argument {nameOfValue} must be a non-negative number.");
            }
        }

        public static void AgainstInvalidXmlString(string xml, string nameOfXml)
        {
            if (string.IsNullOrWhiteSpace(xml))
            {
                throw new ArgumentException($"Argument {nameOfXml} must be valid XML>");
            }

            try
            {
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(xml);
            }
            catch (XmlException)
            {
                throw new ArgumentException($"Argument {nameOfXml} must be a valid XML.");
            }
        }

        public static void AgainstNullEmptyOrWhitespaceString(string stringArg, string nameOfString)
        {
            if (string.IsNullOrEmpty(stringArg))
            {
                throw new ArgumentException($"Argument {nameOfString} must not be null or empty.");
            }

            if (string.IsNullOrWhiteSpace(stringArg))
            {
                throw new ArgumentException($"Argument {nameOfString} must not be null or whitespace.");
            }
        }

        public static void AgainstNullObject(object objArg, string nameOfObj)
        {
            if (objArg == null)
            {
                throw new ArgumentNullException();
            }
        }
    }
}