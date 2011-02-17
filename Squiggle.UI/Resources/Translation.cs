﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Reflection;

namespace Squiggle.UI.Resources
{
    class Translation
    {
        public string Global_ContactSays { get; set; }
        public string Global_You { get; set; }
        public string Global_ContactSaid { get; set; }
        public string Popup_NewMessage { get; set; }
        public string ContactList_SearchContacts { get; set; }
        public string MainWindow_ShareAMessage { get; set; }
        public string ChatWindow_IsTyping { get; set; }
        public string ChatWindow_MessageCouldNotBeDelivered { get; set; }
        public string ChatWindow_HasJoinedConversation { get; set; }
        public string ChatWindow_HasLeftConversation { get; set; }
        public string ChatWindow_HasSentYouBuzz { get; set; }
        public string ChatWindow_YouSentBuzz { get; set; }
        public string ChatWindow_BuzzTooEarly { get; set; }
        public string ChatWindow_CouldNotReadFile { get; set; }
        public string ChatWindow_MakeSureFileNotInUse { get; set; }
        public string ChatWindow_BroadCastChatTitle { get; set; }
        public string ChatWindow_LastMessageAt { get; set; }
        public string ChatWindow_InviteContact { get; set; }
        public string FileTransfer_Waiting { get; set; }
        public string FileTransfer_Cancel { get; set; }
        public string FileTransfer_Reject { get; set; }
        public string FileTransfer_FileSent { get; set; }
        public string FileTransfer_FileReceived { get; set; }
        public string FileTransfer_SendingCancelled { get; set; }
        public string FileTransfer_Cancelled { get; set; }
        public string FileTransfer_Sending { get; set; }
        public string FileTransfer_Receiving { get; set; }
        public string BuddyStatus_Online { get; set; }
        public string BuddyStatus_Busy { get; set; }
        public string BuddyStatus_BeRightBack { get; set; }
        public string BuddyStatus_Away { get; set; }
        public string BuddyStatus_Idle { get; set; }
        public string BuddyStatus_Offline { get; set; }
        public string Emoticon_Angry { get; set; }
        public string Emoticon_Crying { get; set; }
        public string Emoticon_Disappointed { get; set; }
        public string Emoticon_Hot { get; set; }
        public string Emoticon_Laughing { get; set; }
        public string Emoticon_Sad { get; set; }
        public string Emoticon_Sarcastic { get; set; }
        public string Emoticon_Silence { get; set; }
        public string Emoticon_Smile { get; set; }
        public string Emoticon_Surprised { get; set; }
        public string Emoticon_ToungeOut { get; set; }
        public string Emoticon_Wink { get; set; }

        public static Translation Instance { get; set; }

        static Translation()
        {
            Instance = new Translation();
        }

        public static void Initialize()
        {
            Instance = Instance ?? new Translation();
            foreach (PropertyInfo property in typeof(Translation).GetProperties(BindingFlags.Instance | BindingFlags.Public))
            {
                var translation = Application.Current.TryFindResource(property.Name) as String;
                property.SetValue(Instance, translation, null);
            }
        }        
    }
}