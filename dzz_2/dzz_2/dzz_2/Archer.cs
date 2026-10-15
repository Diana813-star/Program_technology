namespace dzz_2
{
    /// <summary>
    /// Представляет игрового персонажа-лучника.
    /// </summary>
    public class Archer : Character, IHealable
    {
        private const int EmptyArrowCount = 0;

        /// <summary>
        /// Возвращает или задаёт количество стрел лучника.
        /// </summary>
        public int ArrowCount { get; set; }

        /// <summary>
        /// Показывает, закончились ли у лучника стрелы.
        /// </summary>
        public bool IsOutOfArrows => ArrowCount <= EmptyArrowCount;

        /// <summary>
        /// Создаёт лучника с указанными параметрами.
        /// </summary>
        /// <param name="id">Идентификатор персонажа.</param>
        /// <param name="name">Имя лучника.</param>
        /// <param name="health">Количество здоровья.</param>
        /// <param name="arrowCount">Количество стрел.</param>
        public Archer(int id, string name, int health, int arrowCount)
            : base(id, name, health)
        {
            ArrowCount = arrowCount;
        }

        /// <summary>
        /// Создаёт лучника с указанным именем.
        /// </summary>
        /// <param name="name">Имя лучника.</param>
        public Archer(string name) : base(name)
        {
            ArrowCount = 0;
        }

        /// <summary>
        /// Выполняет атаку лучника выстрелом из лука.
        /// Если стрел нет, выводит соответствующее сообщение.
        /// </summary>
        public override void Attack()
        {
            if (IsOutOfArrows)
            {
                Console.WriteLine($"{Name} has no arrows.");
                return;
            }

            ArrowCount--;
            Console.WriteLine($"{Name} shoots an arrow.");
        }

        /// <summary>
        /// Восстанавливает здоровье лучника.
        /// </summary>
        /// <param name="amount">Количество восстанавливаемого здоровья.</param>
        public void Heal(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Healing amount must be positive.");
                return;
            }

            Health += amount;
            Console.WriteLine($"{Name} healed by {amount}.");
        }

        /// <summary>
        /// Возвращает строку с информацией о лучнике.
        /// </summary>
        /// <returns>Имя, здоровье, класс и количество стрел.</returns>
        public override string ToString()
        {
            return $"[Archer] {Name}, HP={Health}, class: {Class}, arrows={ArrowCount}";
        }
    }
}
