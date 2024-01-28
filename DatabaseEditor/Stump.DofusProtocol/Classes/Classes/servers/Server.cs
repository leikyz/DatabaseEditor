// Generated on 06/05/2015 03:00:22

using System.Collections.Generic;
using Stump.DofusProtocol.Tools.D2o;

namespace Stump.DofusProtocol.Classes
{
    [D2OClass("Servers", "com.ankamagames.dofus.datacenter.servers", true)]
    public class Server : IDataObject, IIndexedData
    {
        public const string MODULE = "Servers";

        public uint commentId;

        public int communityId;

        public uint gameTypeId;
        public int id;

        public string language;

        public uint nameId;

        public float openingDate;

        public int populationId;

        public List<string> restrictedToLanguages;

        [D2OIgnore]
        public int Id
        {
            get { return id; }

            set { id = value; }
        }

        [D2OIgnore]
        public uint NameId
        {
            get { return nameId; }

            set { nameId = value; }
        }

        [D2OIgnore]
        public uint CommentId
        {
            get { return commentId; }

            set { commentId = value; }
        }

        [D2OIgnore]
        public float OpeningDate
        {
            get { return openingDate; }

            set { openingDate = value; }
        }

        [D2OIgnore]
        public string Language
        {
            get { return language; }

            set { language = value; }
        }

        [D2OIgnore]
        public int PopulationId
        {
            get { return populationId; }

            set { populationId = value; }
        }

        [D2OIgnore]
        public uint GameTypeId
        {
            get { return gameTypeId; }

            set { gameTypeId = value; }
        }

        [D2OIgnore]
        public int CommunityId
        {
            get { return communityId; }

            set { communityId = value; }
        }

        [D2OIgnore]
        public List<string> RestrictedToLanguages
        {
            get { return restrictedToLanguages; }

            set { restrictedToLanguages = value; }
        }

        int IIndexedData.Id
        {
            get { return id; }
        }
    }
}