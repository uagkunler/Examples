using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public static class StateAbbreviations
    {
        public static string GetStateByAbbreviation(int stateNumber)
        {
            switch (stateNumber)
            {
                case 01:
                    return "AL";

                case 02:
                    return "AK";

                case 03:
                    return "AS";

                case 04:
                    return "AZ";

                case 05:
                    return "AR";

                case 06:
                    return "CA";

                case 07:
                    return "CO";

                case 08:
                    return "CT";

                case 09:
                    return "DE";

                case 10:
                    return "DC";

                case 11:
                    return "FM";

                case 12:
                    return "FL";

                case 13:
                    return "GA";

                case 14:
                    return "GU";

                case 15:
                    return "HI";

                case 16:
                    return "ID";

                case 17:
                    return "IL";

                case 18:
                    return "IN";

                case 19:
                    return "IA";

                case 20:
                    return "KS";

                case 21:
                    return "KY";

                case 22:
                    return "LA";

                case 23:
                    return "ME";

                case 24:
                    return "MH";

                case 25:
                    return "MD";

                case 26:
                    return "MA";

                case 27:
                    return "MI";

                case 28:
                    return "MN";

                case 29:
                    return "MS";

                case 30:
                    return "MO";

                case 31:
                    return "MT";

                case 32:
                    return "NE";

                case 33:
                    return "NV";

                case 34:
                    return "NH";

                case 35:
                    return "NJ";

                case 36:
                    return "NM";

                case 37:
                    return "NY";

                case 38:
                    return "NC";

                case 39:
                    return "ND";

                case 40:
                    return "MP";

                case 41:
                    return "OH";

                case 42:
                    return "OK";

                case 43:
                    return "OR";

                case 44:
                    return "PW";

                case 45:
                    return "PA";

                case 46:
                    return "PR";

                case 47:
                    return "RI";

                case 48:
                    return "SC";

                case 49:
                    return "SD";

                case 50:
                    return "TN";

                case 51:
                    return "TX";

                case 52:
                    return "UT";

                case 53:
                    return "VT";

                case 54:
                    return "VI";

                case 55:
                    return "VA";

                case 56:
                    return "WA";

                case 57:
                    return "WV";

                case 58:
                    return "WI";

                case 59:
                    return "WY";
            }

            throw new Exception("Not Available");
        }

        public static string GetState(State state)
        {
            switch (state)
            {
                case State.AL:
                    return "ALABAMA";

                case State.AK:
                    return "ALASKA";

                case State.AS:
                    return "AMERICAN SAMOA";

                case State.AZ:
                    return "ARIZONA";

                case State.AR:
                    return "ARKANSAS";

                case State.CA:
                    return "CALIFORNIA";

                case State.CO:
                    return "COLORADO";

                case State.CT:
                    return "CONNECTICUT";

                case State.DE:
                    return "DELAWARE";

                case State.DC:
                    return "DISTRICT OF COLUMBIA";

                case State.FM:
                    return "FEDERATED STATES OF MICRONESIA";

                case State.FL:
                    return "FLORIDA";

                case State.GA:
                    return "GEORGIA";

                case State.GU:
                    return "GUAM";

                case State.HI:
                    return "HAWAII";

                case State.ID:
                    return "IDAHO";

                case State.IL:
                    return "ILLINOIS";

                case State.IN:
                    return "INDIANA";

                case State.IA:
                    return "IOWA";

                case State.KS:
                    return "KANSAS";

                case State.KY:
                    return "KENTUCKY";

                case State.LA:
                    return "LOUISIANA";

                case State.ME:
                    return "MAINE";

                case State.MH:
                    return "MARSHALL ISLANDS";

                case State.MD:
                    return "MARYLAND";

                case State.MA:
                    return "MASSACHUSETTS";

                case State.MI:
                    return "MICHIGAN";

                case State.MN:
                    return "MINNESOTA";

                case State.MS:
                    return "MISSISSIPPI";

                case State.MO:
                    return "MISSOURI";

                case State.MT:
                    return "MONTANA";

                case State.NE:
                    return "NEBRASKA";

                case State.NV:
                    return "NEVADA";

                case State.NH:
                    return "NEW HAMPSHIRE";

                case State.NJ:
                    return "NEW JERSEY";

                case State.NM:
                    return "NEW MEXICO";

                case State.NY:
                    return "NEW YORK";

                case State.NC:
                    return "NORTH CAROLINA";

                case State.ND:
                    return "NORTH DAKOTA";

                case State.MP:
                    return "NORTHERN MARIANA ISLANDS";

                case State.OH:
                    return "OHIO";

                case State.OK:
                    return "OKLAHOMA";

                case State.OR:
                    return "OREGON";

                case State.PW:
                    return "PALAU";

                case State.PA:
                    return "PENNSYLVANIA";

                case State.PR:
                    return "PUERTO RICO";

                case State.RI:
                    return "RHODE ISLAND";

                case State.SC:
                    return "SOUTH CAROLINA";

                case State.SD:
                    return "SOUTH DAKOTA";

                case State.TN:
                    return "TENNESSEE";

                case State.TX:
                    return "TEXAS";

                case State.UT:
                    return "UTAH";

                case State.VT:
                    return "VERMONT";

                case State.VI:
                    return "VIRGIN ISLANDS";

                case State.VA:
                    return "VIRGINIA";

                case State.WA:
                    return "WASHINGTON";

                case State.WV:
                    return "WEST VIRGINIA";

                case State.WI:
                    return "WISCONSIN";

                case State.WY:
                    return "WYOMING";
            }

            throw new Exception("Not Available");
        }

        public static State GetStateByName(string name)
        {
            switch (name.ToUpper())
            {
                case "ALABAMA":
                    return State.AL;

                case "ALASKA":
                    return State.AK;

                case "AMERICAN SAMOA":
                    return State.AS;

                case "ARIZONA":
                    return State.AZ;

                case "ARKANSAS":
                    return State.AR;

                case "CALIFORNIA":
                    return State.CA;

                case "COLORADO":
                    return State.CO;

                case "CONNECTICUT":
                    return State.CT;

                case "DELAWARE":
                    return State.DE;

                case "DISTRICT OF COLUMBIA":
                    return State.DC;

                case "FEDERATED STATES OF MICRONESIA":
                    return State.FM;

                case "FLORIDA":
                    return State.FL;

                case "GEORGIA":
                    return State.GA;

                case "GUAM":
                    return State.GU;

                case "HAWAII":
                    return State.HI;

                case "IDAHO":
                    return State.ID;

                case "ILLINOIS":
                    return State.IL;

                case "INDIANA":
                    return State.IN;

                case "IOWA":
                    return State.IA;

                case "KANSAS":
                    return State.KS;

                case "KENTUCKY":
                    return State.KY;

                case "LOUISIANA":
                    return State.LA;

                case "MAINE":
                    return State.ME;

                case "MARSHALL ISLANDS":
                    return State.MH;

                case "MARYLAND":
                    return State.MD;

                case "MASSACHUSETTS":
                    return State.MA;

                case "MICHIGAN":
                    return State.MI;

                case "MINNESOTA":
                    return State.MN;

                case "MISSISSIPPI":
                    return State.MS;

                case "MISSOURI":
                    return State.MO;

                case "MONTANA":
                    return State.MT;

                case "NEBRASKA":
                    return State.NE;

                case "NEVADA":
                    return State.NV;

                case "NEW HAMPSHIRE":
                    return State.NH;

                case "NEW JERSEY":
                    return State.NJ;

                case "NEW MEXICO":
                    return State.NM;

                case "NEW YORK":
                    return State.NY;

                case "NORTH CAROLINA":
                    return State.NC;

                case "NORTH DAKOTA":
                    return State.ND;

                case "NORTHERN MARIANA ISLANDS":
                    return State.MP;

                case "OHIO":
                    return State.OH;

                case "OKLAHOMA":
                    return State.OK;

                case "OREGON":
                    return State.OR;

                case "PALAU":
                    return State.PW;

                case "PENNSYLVANIA":
                    return State.PA;

                case "PUERTO RICO":
                    return State.PR;

                case "RHODE ISLAND":
                    return State.RI;

                case "SOUTH CAROLINA":
                    return State.SC;

                case "SOUTH DAKOTA":
                    return State.SD;

                case "TENNESSEE":
                    return State.TN;

                case "TEXAS":
                    return State.TX;

                case "UTAH":
                    return State.UT;

                case "VERMONT":
                    return State.VT;

                case "VIRGIN ISLANDS":
                    return State.VI;

                case "VIRGINIA":
                    return State.VA;

                case "WASHINGTON":
                    return State.WA;

                case "WEST VIRGINIA":
                    return State.WV;

                case "WISCONSIN":
                    return State.WI;

                case "WYOMING":
                    return State.WY;
            }

            throw new Exception("Not Available");
        }

        public enum State
        {
            AL,
            AK,
            AS,
            AZ,
            AR,
            CA,
            CO,
            CT,
            DE,
            DC,
            FM,
            FL,
            GA,
            GU,
            HI,
            ID,
            IL,
            IN,
            IA,
            KS,
            KY,
            LA,
            ME,
            MH,
            MD,
            MA,
            MI,
            MN,
            MS,
            MO,
            MT,
            NE,
            NV,
            NH,
            NJ,
            NM,
            NY,
            NC,
            ND,
            MP,
            OH,
            OK,
            OR,
            PW,
            PA,
            PR,
            RI,
            SC,
            SD,
            TN,
            TX,
            UT,
            VT,
            VI,
            VA,
            WA,
            WV,
            WI,
            WY
        }
    }
}
