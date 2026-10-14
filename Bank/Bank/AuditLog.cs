using System;
using System.Collections.Generic;

namespace Bank
{
    /// <summary>
    /// Предоставляет глобальный журнал аудита для фиксации и отображения финансовых операций.
    /// </summary>
    public class AuditLog
    {
        /// <summary>
        /// Внутреннее хранилище записей журнала.
        /// </summary>
        private static readonly List<string> _logs = new List<string>();

        /// <summary>
        /// Добавляет новую запись о финансовой операции в журнал аудита.
        /// </summary>
        /// <param name="accountNumber">Уникальный номер банковского счёта.</param>
        /// <param name="operationType">Тип совершённой операции (например, Депозит, Снятие).</param>
        /// <param name="amount">Денежная сумма, задействованная в операции.</param>
        /// <param name="date">Дата и время проведения операции.</param>
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

        /// <summary>
        /// Выводит все зафиксированные записи журнала аудита в консоль.
        /// </summary>
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
