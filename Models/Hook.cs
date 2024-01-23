using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaesenToolkit.Models
{
    internal class Hook
    {
        int Id { get; set; }
        public Invitation invitation { get; set; }
        public QuestGiver questGiver { get; set; }

        public Hook(Invitation invitation, QuestGiver questGiver) 
        {
            this.invitation = invitation;
            this.questGiver = questGiver;
        }

        public string InvitationContentToString()
        {
            return this.invitation.content;
        }

        public string QuestGiverContentToString()
        {
            return this.questGiver.content;
        }
    }
}
