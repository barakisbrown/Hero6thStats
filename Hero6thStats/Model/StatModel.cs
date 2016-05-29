namespace Hero6thStats.Model
{
    using GalaSoft.MvvmLight;
    /// <summary>
    /// Model for a single stat in the Hero 6th System
    /// </summary>
    public class StatModel : ObservableObject
    {
        private int _actualValue;
        private string _name;
        private int _baseValue;
        private int _cost;
        private int _totalPoints;
        private int _skillRoll;

        public int Value
        {
            get { return _actualValue; }
            set
            {
                SkillRoll = (value + 9)/5;
                Set("VALUE", ref _actualValue, value);
            }
        }

        public string Name
        {
            get { return _name; }
            set { Set("NAME", ref _name, value); }
        }

        public int BaseValue
        {
            get { return _baseValue; }
            set { Set("BASEVALUE", ref _baseValue, value); }
        }

        public int Cost
        {
            get { return _cost;}
            set { Set("COST", ref _cost, value); }
        }

        public int Points
        {
            get { return _totalPoints; }
            set { Set("POINTS", ref _totalPoints, value); }
        }

        public int SkillRoll
        {
            get { return _skillRoll; }
            set { Set("SKILL",ref _skillRoll, value); }
        }
    }
}