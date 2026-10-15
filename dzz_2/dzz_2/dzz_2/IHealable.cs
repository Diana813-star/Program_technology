namespace dzz_2
{
    /// <summary>
    /// Определяет возможность лечения персонажа.
    /// </summary>
    public interface IHealable
    {
        /// <summary>
        /// Восстанавливает здоровье персонажа на указанное количество единиц.
        /// </summary>
        void Heal(int amount);
    }
}
