namespace dzz_2
{
    /// <summary>
    /// Представляет игрового персонажа-мага.
    /// </summary>
    public class Mage : Character
    {
        private const int PowerfulManaThreshold = 100;

        /// <summary>
        /// Возвращает или задаёт количество маны мага.
        /// </summary>
        public int Mana { get; set; }

        /// <summary>
        /// Показывает, обладает ли маг достаточным запасом маны.
        /// </summary>
        public bool IsPowerful => Mana >= PowerfulManaThreshold;

        /// <summary>
        /// Создаёт мага с указанными параметрами.
        /// </summary>
        /// <param name="id">Идентификатор персонажа.</param>
        /// <param name="name">Имя мага.</param>
        /// <param name="health">Количество здоровья.</param>
        /// <param name="mana">Количество маны.</param>
        public Mage(int id, string name, int health, int mana)
            : base(id, name, health)
        {
            Mana = mana;
        }

        /// <summary>
        /// Создаёт мага с указанным именем.
        /// </summary>
        /// <param name="name">Имя мага.</param>
        public Mage(string name) : base(name)
        {
            Mana = 0;
        }

        /// <summary>
        /// Выполняет магическую атаку огненным шаром.
        /// </summary>
        public override void Attack()
        {
            Console.WriteLine($"{Name} casts a fireball.");
        }

        /// <summary>
        /// Возвращает строку с информацией о маге.
        /// </summary>
        /// <returns>Имя, здоровье, класс и количество маны.</returns>
        public override string ToString()
        {
            return $"[Mage] {Name}, HP={Health}, class: {Class}, mana={Mana}";
        }
    }
}
