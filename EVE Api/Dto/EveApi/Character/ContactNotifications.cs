﻿using System;
using System.Xml.Serialization;

namespace eZet.Eve.EolNet.Dto.EveApi.Character {
    public class ContactNotifications : XmlResult {

        [XmlElement("rowset")]
        public XmlRowSet<Notification> Notifications { get; set; }
            
        [Serializable]
        [XmlRoot("row")]
        public class Notification {

            [XmlAttribute("notificationID")]
            public long NotificationId { get; set; }

            [XmlAttribute("senderID")]
            public long SenderId { get; set; }

            [XmlAttribute("senderName")]
            public string SenderName { get; set; }

            [XmlIgnore]
            public DateTime SentDate { get; private set; }

            [XmlAttribute("sentDate")]
            public string SentDateAsString {
                get { return SentDate.ToString(DateFormat); }
                set { SentDate = DateTime.ParseExact(value, DateFormat, null); }
            }

            [XmlAttribute("messageData")]
            public string MessageData { get; set; }
        }
    }
}