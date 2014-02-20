﻿using System;
using System.Xml.Serialization;

namespace eZet.Eve.EveApi.Dto.EveApi.Corporation {
    public class ContainerLog : XmlResult {

        [XmlElement("rowset")]
        public XmlRowSet<LogEntry> LogEntries { get; set; }

        [Serializable]
        [XmlRoot("row")]
        public class LogEntry {

            // TODO DateTime
            [XmlAttribute("logTime")]
            public string LogTime { get; set; }

            [XmlAttribute("itemID")]
            public long ItemId { get; set; }

            [XmlAttribute("itemTypeID")]
            public long itemTypeId { get; set; }

            [XmlAttribute("actorID")]
            public long ActorId { get; set; }

            [XmlAttribute("actorName")]
            public string ActorName { get; set; }

            [XmlAttribute("flag")]
            public int Flag { get; set; }

            [XmlAttribute("locationID")]
            public long LocationId { get; set; }

            [XmlAttribute("action")]
            public string Action { get; set; }

            [XmlAttribute("passwordType")]
            public string PasswordType { get; set; }

            /// <summary>
            /// Can be empty string
            /// </summary>
            [XmlAttribute("typeID")]
            public string TypeId { get; set; }

            /// <summary>
            /// Can be empty string
            /// </summary>
            [XmlAttribute("quantity")]
            public string Quantity { get; set; }

            [XmlAttribute("oldConfiguration")]
            public string OldConfiguration { get; set; }

            [XmlAttribute("newConfiguration")]
            public string NewConfiguration { get; set; }
            
        }
    }
}
