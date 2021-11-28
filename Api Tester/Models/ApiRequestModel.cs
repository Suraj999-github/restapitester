using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_Tester.Models
{
    public class ApiRequestModel
    {
        public Apicredentials apicredentials { get; set; }
        public InternetModel internetModel { get; set; }
        public User user { get; set; }
        public string productId { get; set; }
        public string agentCode { get; set; }
        public string userName { get; set; }
        public string requestedIP { get; set; }
        public string deviceInfo { get; set; }
        public string browserInfo { get; set; }
        public string environment { get; set; }
        public string requestedMedium { get; set; }
        public string storedProcedure { get; set; }
        public string request_Id { get; set; }
        public int gateway { get; set; }
        public int topupType { get; set; }
        public string gatewayId { get; set; }
        public string amount { get; set; }
        public string processId { get; set; }
        public string dob { get; set; }
        public string transaction_Id { get; set; }
        public string package_Name { get; set; }
        public string package_code { get; set; }
        public string scNo { get; set; }
        public string consumerId { get; set; }
        public string neaCounter { get; set; }
        public string smartCardId { get; set; }
        public string cas_id { get; set; }
        public string stbiDorCASIDorCHIPID { get; set; }
        public string optionalToken { get; set; }
        public string mobile_number { get; set; }
        public string customerId { get; set; }
        public string subscriber { get; set; }
        public string code { get; set; }
        public string amountPaisa { get; set; }
        public string session_id { get; set; }
        public string customer_id { get; set; }
        public string bank_transaction_id { get; set; }
        public string stock_id { get; set; }
        public string product_id { get; set; }
        public string refcode { get; set; }
        public string token { get; set; }
        public string email { get; set; }
        public int faceValue { get; set; }
        public string txnId { get; set; }
        public string transactionId { get; set; }
        public List<TicketDetail> ticketDetails { get; set; }
        public string customerWalletId { get; set; }
        public string totalPrice { get; set; }
        public string referenceNo { get; set; }
        public string subscriberType { get; set; }
        public string fromDate { get; set; }
        public string toDate { get; set; }
        public string from { get; set; }
        public string to { get; set; }
        public string departureDate { get; set; }
        public string returnDate { get; set; }
        public string way { get; set; }
        public string adultCount { get; set; }
        public string childCount { get; set; }
        public string nationality { get; set; }
        public string outBoundFlightId { get; set; }
        public string inBoundFlightId { get; set; }
        public string contactPerson { get; set; }
        public string address { get; set; }
        public string currency { get; set; }
        public List<AdultPassenger> adultPassengers { get; set; }
        public List<ChildPassenger> childPassengers { get; set; }
        public string counterId { get; set; }
        public string month { get; set; }
        public string counterName { get; set; }
        public string partneR_TXN_ID { get; set; }
        public string txN_SIGNATURE { get; set; }
        public string voucher_code { get; set; }
        public string year { get; set; }
        public string PNRNumber { get; set; }
        public string TicketNumber { get; set; }
        public string AirlineID { get; set; }
        public string AccountId { get; set; }
        public string Remarks { get; set; }
        public string GatewayIds { get; set; }
        public string ReturnURL { get; set; }
        public string CustName { get; set; }
        public string CustEmail { get; set; }
        public string CustMobile { get; set; }
        public string AccountName { get; set; }
        public string AccountNumber { get; set; }
        public string DateOfBirth { get; set; }
        public string MobileNumber { get; set; }
        public string Identifier { get; set; }
        public string BankCode { get; set; }
        public string OTPCode { get; set; }
    }
    public class Apicredentials
    {
        public string productId { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public string apiBaseURL { get; set; }
        public string apiurl { get; set; }
        public string requestedMethod { get; set; }
        public string accessCode { get; set; }
        public string apiToken { get; set; }
        public string securityCode { get; set; }
        public string gateWayBalance { get; set; }
        public string agentCode { get; set; }
    }

    public class InternetPackage
    {
        public string planId { get; set; }
        public string planName { get; set; }
    }

    public class InternetModel
    {
        public int gateWay { get; set; }
        public string productId { get; set; }
        public string productName { get; set; }
        public string subscriberName { get; set; }
        public string subscriberPakage { get; set; }
        public string pakageType { get; set; }
        public string branch { get; set; }
        public string daysRemaining { get; set; }
        public string message { get; set; }
        public List<InternetPackage> internetPackage { get; set; }
        public int billAmount { get; set; }
    }

    public class User
    {
        public string username { get; set; }
        public string accessCode { get; set; }
        public string apiToken { get; set; }
        public string requestMedium { get; set; }
        public string agentCode { get; set; }
        public string agentType { get; set; }
    }

    public class TicketDetail
    {
        public string tripType { get; set; }
        public string passengerType { get; set; }
        public string passengerCount { get; set; }
    }

    public class AdultPassenger
    {
        public string title { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
    }

    public class ChildPassenger
    {
        public string title { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
    }
    public class ApiJosn
    {
        public string BaseUrl { get; set; }
       
    }
    public class DomesticAirlineList
    {
        public string productId { get; set; }
        public string agentCode { get; set; }
        public string userName { get; set; }
        public string requestedIP { get; set; }
        public string deviceInfo { get; set; }
        public string browserInfo { get; set; }
        public string environment { get; set; }
        public string requestedMedium { get; set; }
        public string request_Id { get; set; }
        public int gateway { get; set; }
        public int topupType { get; set; }
        public string gatewayId { get; set; }
        public string from { get; set; }
        public string to { get; set; }
        public string departureDate { get; set; }
        public string returnDate { get; set; }
        public string way { get; set; }
        public string adultCount { get; set; }
        public string childCount { get; set; }
        public string nationality { get; set; }
    }
}
