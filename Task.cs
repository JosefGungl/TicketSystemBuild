using System;
using System.Collections.Generic;

namespace TicketSystemBuild
{
    public class Task
    {
        public UInt64 ticketId {get; set;}
        public string summary {get; set;}
        public string status {get; set;}
        public string priority {get; set;}
        public string submitter {get; set;}
        public string assigned {get; set;}
        public string watching {get; set;}

        public string projectName {get; set;}
        public DateTime dueDate {get; set;}

        public string Display(){
            return $"TicketID: {ticketId}, Summary: {summary}, Status: {status}, Priority: {priority}, Submitter: {submitter}, Assigned: {assigned}, Watching: {watching}, Project Name: {projectName}, Due Date: {dueDate}";
        }
    }
} 