namespace Hero6thStats.Model
{
    using System.Collections.Generic;
    using GalaSoft.MvvmLight;
    /// <summary>
    /// Composite Class of all my StatModels
    /// </summary>
    public class Stats : ObservableObject
    {
        private readonly List<StatModel> _list = new List<StatModel>();

        public Stats()
        {
            for (int Loop = 0; Loop < 19; Loop++)
            {
                _list.Add(new StatModel());
            }
        }


        public StatModel STR
        {
            get { return _list[0]; }
            set { _list[0] = value; }
        }

        public StatModel DEX
        {
            get { return _list[1]; }
            set { _list[1] = value; }
        }

        public StatModel CON
        {
            get { return _list[2]; }
            set { _list[2] = value; }
        }

        public StatModel INT
        {
            get { return _list[3]; }
            set { _list[3] = value; }
        }

        public StatModel PRE
        {
            get { return _list[4]; }
            set { _list[4] = value; }
        }

        public StatModel EGO
        {
            get { return _list[5]; }
            set { _list[5] = value; }
        }

        public StatModel OMCV
        {
            get { return _list[6]; }
            set { _list[6] = value; }
        }

        public StatModel DMCV
        {
            get { return _list[7]; }
            set { _list[7] = value; }
        }

        public StatModel OCV
        {
            get { return _list[8]; }
            set { _list[8] = value; }
        }

        public StatModel DCV
        {
            get { return _list[9]; }
            set { _list[9] = value; }
        }

        public StatModel PD
        {
            get { return _list[10]; }
            set { _list[10] = value; }
        }

        public StatModel rPD
        {
            get { return _list[11]; }
            set { _list[11] = value; }
        }

        public StatModel ED
        {
            get { return _list[12]; }
            set { _list[12] = value; }
        }

        public StatModel rED
        {
            get { return _list[13]; }
            set { _list[13] = value; }
        }

        public StatModel SPD
        {
            get { return _list[14]; }
            set { _list[14] = value; }
        }

        public StatModel REC
        {
            get { return _list[15]; }
            set { _list[15] = value; }
        }

        public StatModel END
        {
            get { return _list[16]; }
            set { _list[16] = value; }
        }

        public StatModel BODY
        {
            get { return _list[17]; }
            set { _list[17] = value; }
        }

        public StatModel STUN
        {
            get { return _list[18]; }
            set { _list[18] = value; }
        }
    }
}