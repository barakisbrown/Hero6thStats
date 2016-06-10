using System;

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
                SkillRoll = value;
                var result = (value - BaseValue);
                
                switch (Name)
                {
                    case "END":
                        if (result%5 == 0)
                        {
                            Points = result/5;
                        }
                        break;
                    case "STUN":
                        if (result%2 == 0)
                        {
                            Points = result/2;
                        }
                        break;
                    default:
                        Points = result * _cost;
                        break;
                }                
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
            set
            {
                switch (Name)
                {
                    case "STR":
                    case "DEX":
                    case "INT":
                    case "EGO":
                    case "CON":
                    case "PRE":
                    case "BODY":
                    {
                        _skillRoll = (value/5) + 9;
                        break;
                    }
                    default:
                    {
                        _skillRoll = 0;
                        break;
                    }
                }
                Set("SKILL",ref _skillRoll, value);
            }
        }
    }
}