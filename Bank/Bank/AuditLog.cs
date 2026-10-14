using System;
using System.Collections.Generic;

namespace Bank
{
    public class AuditLog
    {
        private static readonly List<string> _logs = new List<string>();

        public static void WriteLog(
            string accountNumber,
            string operationType,
            decimal amount,
            DateTime date)
        {
            string entry =
                $"Счёт: {accountNumber} | " +
                $"Операция: {operationType} | " +
                $"Сумма: {amount} руб. | " +
                $"Дата: {date}";

            _logs.Add(entry);
        }

        public static void ShowLog()
        {
            Console.WriteLine("Журнал аудита:");

            foreach (string entry in _logs)
            {
                Console.WriteLine(entry);
            }
        }
    }
}