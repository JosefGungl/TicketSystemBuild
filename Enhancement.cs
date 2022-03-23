using System;
using System.Collections.Generic;

namespace TicketSystemBuild

{
    public class Enhancement
    {
        public UInt64 ticketId {get; set;}
        public string summary {get; set;}
        public string status {get; set;}
        public string priority {get; set;}
        public string submitter {get; set;}
        public string assigned {get; set;}
        public string watching {get; set;}

        public string software {get; set;}
        public string cost {get; set;}
        public string reason {get; set;}
        public string estimate {get; set;}

        public string Display(){
            return $"TicketID: {ticketId}, Summary: {summary}, Status: {status}, Priority: {priority}, Submitter: {submitter}, Assigned: {assigned}, Watching: {watching}, Software: {software}, Cost: {cost}, Reason: {reason}, Estimate: {estimate}";
        }
    }
} 