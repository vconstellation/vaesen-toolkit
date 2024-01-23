using System;
using System.Diagnostics;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using VaesenToolkit.Models;

namespace VaesenToolkit.Middleware
{
    public class JLo: RandomizeHelper
    {
        List<Invitation> invites;
        List<QuestGiver> givers;
        public void InitJLo()
        {
            // deserialize invitations
            DeserializeInvitations();
            DeserializeQuestGivers();
        }

        private void DeserializeInvitations()
        {
            string fileName = "C:\\Users\\astrocat\\source\\repos\\VaesenToolkit\\VaesenToolkit\\Data\\Initation.json";
            string jsonString = File.ReadAllText(fileName);

            invites = JsonSerializer.Deserialize<List<Invitation>>(jsonString);
        }

        private void DeserializeQuestGivers()
        {
            string fileName = "C:\\Users\\astrocat\\source\\repos\\VaesenToolkit\\VaesenToolkit\\Data\\QuestGiver.json";
            string jsonString = File.ReadAllText(fileName);

            givers = JsonSerializer.Deserialize<List<QuestGiver>>(jsonString);
        }

        private Invitation GetRandomInvitation()
        {
            int index = GetRandomRecord(invites.Count);
            return invites[index];
        }

        private QuestGiver GetRandomQuestGiver()
        {
            int index = GetRandomRecord(givers.Count);
            return givers[index];
        }

        internal Hook GetRandomHook()
        {
            // string randomQuestGiver = GetRandomQuestGiver().content;
            // string randomInvitation = GetRandomInvitation().content;

            Hook hook = new Hook(GetRandomInvitation(), GetRandomQuestGiver());

            return hook;
        }
    }
}
