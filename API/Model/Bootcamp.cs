using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationAPI.API.Model
{
    internal struct Bootcamp
    {
        public string startDate;
        public string endDate;
        public string id;
        public string name;
        public string description;
        public string location;
        public sbyte workflowType;
        public byte departmentType;
        public short projectType;
        public string workflow;
        public string department;
        public ushort participantsExpectedQuantity;
        public int acceptedParticipants;
        public uint actualParticipants;
        public string project;
    }
}
