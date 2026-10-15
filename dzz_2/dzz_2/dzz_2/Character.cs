namespace dzz_2
{

    /// <summary>
    /// Представляет базовый абстрактный класс игрового персонажа.
    /// </summary>
    public abstract class Character
    {
        private readonly int _id;

        /// <summary>
        /// Возвращает идентификатор персонажа.
        /// </summary>
        public int Id => _id;

        /// <summary>
        /// Возвращает или задаёт имя персонажа.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Возвращает или задаёт количество здоровья персонажа.
        /// </summary>
        public int Health { get; set; }

        /// <summary>
        /// Возвращает или задаёт класс персонажа.
        /// По умолчанию установлен класс воина.
        /// </summary>
        public CharacterClass Class { get; set; } =
            CharacterClass.Warrior;

        /// <summary>
        /// Показывает, жив ли персонаж.
        /// </summary>
        public bool IsAlive => Health > 0;

        /// <summary>
        /// Создаёт персонажа с указанным идентификатором,
        /// именем и количеством здоровья.
        /// </summary>
        /// <param name="id">Идентификатор персонажа.</param>
        /// <param name="name">Имя персонажа.</param>
        /// <param name="health">Количество здоровья.</param>
        public Character(int id, string name, int health)
        {
            _id = id;
            Name = name;
            Health = health;
        }

        /// <summary>
        /// Создаёт персонажа с указанным именем,
        /// идентификатором 0 и здоровьем 100.
        /// </summary>
        /// <param name="name">Имя персонажа.</param>
        public Character(string name) : this(0, name, 100)
        {
        }

        /// <summary>
        /// Выполняет атаку, определяемую классом персонажа.
        /// </summary>
        public abstract void Attack();
    }
}