using System;

namespace Bank
{
    /// <summary>
    /// Предоставляет статические методы для выполнения денежных переводов между банковскими счетами.
    /// </summary>
    public static class BankTransfer
    {
        /// <summary>
        /// Выполняет перевод указанной суммы со одного банковского счёта на другой.
        /// </summary>
        /// <param name="from">Счёт-отправитель, с которого списываются средства.</param>
        /// <param name="to">Счёт-получатель, на который зачисляются средства.</param>
        /// <param name="amount">Сумма перевода.</param>
        /// <exception cref="ArgumentNullException">
        /// Возникает, если один из счетов (отправитель или получатель) равен <see langword="null"/>.
        /// </exception>
        /// <exception cref="InvalidOperationException">
        /// Возникает при попытке перевести средства на тот же самый счёт.
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Возникает, если сумма перевода меньше или равна нулю.
        /// </exception>
        public static void Transfer(
            BankAccount from,
            BankAccount to,
            decimal amount)
        {
            if (from == null || to == null)
            {
                throw new ArgumentNullException(
                    "Счета не должны быть пустыми");
            }

            if (from == to)
            {
                throw new InvalidOperationException(
                    "Нельзя переводить деньги на тот же счёт");
            }

            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(amount),
                    "Сумма перевода должна быть положительной");
            }

            from.MakeWithdrawal(
                amount,
                DateTime.UtcNow,
                "Transfer to account " + to.Number);

            to.MakeDeposit(
                amount,
                DateTime.UtcNow,
                "Transfer from account " + from.Number);
        }
    }
}
