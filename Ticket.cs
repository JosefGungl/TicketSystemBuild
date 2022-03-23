using System;
using System.Collections.Generic;

namespace TicketSystemBuild
{
    public class Ticket
    {
        public UInt64 ticketId {get; set;}
        public string summary {get; set;}
        public string status {get; set;}
        public string priority {get; set;}
        public string submitter {get; set;}
        public string assigned {get; set;}
        public string watching {get; set;}

        public string severity {get; set;}


        public string Display(){
            return $"TicketID: {ticketId}, Summary: {summary}, Status: {status}, Priority: {priority}, Submitter: {submitter}, Assigned: {assigned}, Watching: {watching}, Severity: {severity}";
        }
    }
} 