using System;
using Hero6thStats.Model;

namespace Hero6thStats.Design
{
    public class DesignDataService : IDataService
    {
        public void GetData(Action<Stats, Exception> callback)
        {
            // Use this to create design time data

            Stats item = LoadDefaults();
            callback(item, null);
        }

        public Stats LoadDefaults()
        {
            Stats item = new Stats();

            // VALUES THAT ARE SIMILAR
            item.STR.Value = item.DEX.Value = item.CON.Value = item.INT.Value = item.PRE.Value = item.EGO.Value = 10;
            item.STR.BaseValue =
                item.DEX.BaseValue =
                    item.CON.BaseValue = item.INT.BaseValue = item.PRE.BaseValue = item.EGO.BaseValue = 10;
            item.STR.Points =
                item.DEX.Points = item.CON.Points = item.INT.Points = item.PRE.Points = item.EGO.Points = 0;
            // STR
            item.STR.Name = "STR";
            item.STR.Cost = 1;
            // DEX
            item.DEX.Name = "DEX";
            item.DEX.Cost = 2;
            // CON
            item.CON.Name = "CON";
            item.CON.Cost = 1;
            // INT
            item.INT.Name = "INT";
            item.INT.Cost = 1;
            // EGO
            item.EGO.Name = "EGO";
            item.EGO.Cost = 1;
            // PRE
            item.PRE.Name = "PRE";
            item.PRE.Cost = 1;

            // CV VALUES(OCV/DCV & OMCV/DMCV)

            // SIMILAR VALUES
            item.OMCV.Value = item.DMCV.Value = item.OCV.Value = item.DCV.Value = 3;
            item.OMCV.BaseValue = item.DMCV.BaseValue = item.OCV.BaseValue = item.DCV.BaseValue = 3;
            item.OMCV.Points = item.DMCV.Points = item.OCV.Points = item.DCV.Points = 0;
            // OCV
            item.OCV.Name = "OCV";
            item.OCV.Cost = 5;
            // DCV
            item.DCV.Name = "DCV";
            item.DCV.Cost = 5;
            // OMCV
            item.OMCV.Name = "OMCV";
            item.OMCV.Cost = 3;
            // DMCV
            item.DMCV.Name = "DMCV";
            item.DMCV.Cost = 3;

            // DEF VALUES(PD/rPD & ED/rED)

            // SIMILAR VALUES
            item.PD.Value = item.rPD.Value = item.ED.Value = item.rED.Value = 2;
            item.PD.BaseValue = item.rPD.BaseValue = item.ED.BaseValue = item.rED.BaseValue = 2;
            item.PD.Cost = item.rPD.Cost = item.ED.Cost = item.rED.Cost = 1;
            item.PD.Points = item.rPD.Points = item.ED.Points = item.rED.Points = 0;
            // PD
            item.PD.Name = "PD";
            item.rPD.Name = "rPD";
            // ED
            item.ED.Name = "ED";
            item.rED.Name = "rED";

            // FIGURED STATS(5TH EDTION TERM)
            // SPD
            item.SPD.Value = item.SPD.BaseValue = 2;
            item.SPD.Name = "SPD";
            item.SPD.Cost = 10;
            item.SPD.Points = 0;
            // REC
            item.REC.Value = item.REC.BaseValue = 4;
            item.REC.Name = "REC";
            item.REC.Cost = 1;
            item.REC.Points = 0;
            // END
            item.END.Value = item.END.BaseValue = 20;
            item.END.Name = "END";
            item.END.Cost = 5;
            item.END.Points = 0;
            // BODY
            item.BODY.Value = item.BODY.BaseValue = 10;
            item.BODY.Name = "BODY";
            item.BODY.Cost = 1;
            item.BODY.Points = 0;
            // STUN
            item.STUN.Value = item.STUN.BaseValue = 20;
            item.STUN.Name = "STUN";
            item.STUN.Cost = 1;
            item.STUN.Points = 0;
            // FINISHED WITH DEFAULTS
            return item;
        }
    }
}