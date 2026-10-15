namespace dzz_2
{
    /// <summary>
    /// Представляет игрового персонажа-воина.
    /// </summary>
    public class Warrior : Character, IHealable
    {
        private const int TankArmorThreshold = 50;

        /// <summary>
        /// Возвращает или задаёт значение брони воина.
        /// </summary>
        public int Armor { get; set; }

        /// <summary>
        /// Показывает, считается ли воин танком.
        /// </summary>
        public bool IsTank => Armor >= TankArmorThreshold;

        /// <summary>
        /// Создаёт воина с указанными параметрами.
        /// </summary>
        /// <param name="id">Идентификатор персонажа.</param>
        /// <param name="name">Имя воина.</param>
        /// <param name="health">Количество здоровья.</param>
        /// <param name="armor">Значение брони.</param>
        public Warrior(int id, string name, int health, int armor)
            : base(id, name, health)
        {
            Armor = armor;
        }

        /// <summary>
        /// Создаёт воина с указанным именем.
        /// </summary>
        /// <param name="name">Имя воина.</param>
        public Warrior(string name) : base(name)
        {
            Armor = 0;
        }

        /// <summary>
        /// Выполняет атаку воина мечом.
        /// </summary>
        public override void Attack()
        {
            Console.WriteLine($"{Name} swings sword.");
        }

        /// <summary>
        /// Восстанавливает здоровье воина.
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
        /// Возвращает строку с информацией о воине.
        /// </summary>
        /// <returns>Имя, здоровье, класс и броня воина.</returns>
        public override string ToString()
        {
            return $"[Warrior] {Name}, HP={Health}, class: {Class}, armor={Armor}";
        }
    }
}

