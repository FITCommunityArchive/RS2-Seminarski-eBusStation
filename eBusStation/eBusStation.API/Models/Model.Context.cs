﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eBusStation.API.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class eBusStation_Entities : DbContext
    {
        public eBusStation_Entities()
            : base("name=eBusStation_Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__EFMigrationsHistory> C__EFMigrationsHistory { get; set; }
        public virtual DbSet<Autobusi> Autobusi { get; set; }
        public virtual DbSet<AutorizacijskiToken> AutorizacijskiToken { get; set; }
        public virtual DbSet<Drzave> Drzave { get; set; }
        public virtual DbSet<Gradovi> Gradovi { get; set; }
        public virtual DbSet<Karte> Karte { get; set; }
        public virtual DbSet<Kartice> Kartice { get; set; }
        public virtual DbSet<KretanjeAutobusa> KretanjeAutobusa { get; set; }
        public virtual DbSet<Linije> Linije { get; set; }
        public virtual DbSet<Popusti> Popusti { get; set; }
        public virtual DbSet<PopustNaLiniji> PopustNaLiniji { get; set; }
        public virtual DbSet<PosjecujeLokacije> PosjecujeLokacije { get; set; }
        public virtual DbSet<PosjedujeAutobuse> PosjedujeAutobuse { get; set; }
        public virtual DbSet<Prevoznici> Prevoznici { get; set; }
        public virtual DbSet<Recenzije> Recenzije { get; set; }
        public virtual DbSet<SredstvoPlacanja> SredstvoPlacanja { get; set; }
        public virtual DbSet<Stanice> Stanice { get; set; }
        public virtual DbSet<TipoviKarte> TipoviKarte { get; set; }
        public virtual DbSet<TransakcijaStavke> TransakcijaStavke { get; set; }
        public virtual DbSet<Transakcije> Transakcije { get; set; }
        public virtual DbSet<Uloge> Uloge { get; set; }
        public virtual DbSet<VrstaAutobusa> VrstaAutobusa { get; set; }
        public virtual DbSet<Korisnici> Korisnici { get; set; }
        public virtual DbSet<Obavijesti> Obavijesti { get; set; }
        public virtual DbSet<SaobracajniDnevnik> SaobracajniDnevnik { get; set; }
    
        public virtual ObjectResult<usp_GetAllUsers_Result> GetAllUsers()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_GetAllUsers_Result>("GetAllUsers");
        }
    
        public virtual ObjectResult<usp_Get_User_Result> Get_UserByCredentials(string username)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_Get_User_Result>("Get_UserByCredentials", usernameParameter);
        }
    
        public virtual int usp_Edit_Users_Hash(string hash)
        {
            var hashParameter = hash != null ?
                new ObjectParameter("hash", hash) :
                new ObjectParameter("hash", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_Edit_Users_Hash", hashParameter);
        }
    
        public virtual ObjectResult<usp_Get_All_Relations_Result> Get_All_Relations()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_Get_All_Relations_Result>("Get_All_Relations");
        }
    
        public virtual int Add_Info_Notification(Nullable<int> linijaId, string tekst)
        {
            var linijaIdParameter = linijaId.HasValue ?
                new ObjectParameter("LinijaId", linijaId) :
                new ObjectParameter("LinijaId", typeof(int));
    
            var tekstParameter = tekst != null ?
                new ObjectParameter("Tekst", tekst) :
                new ObjectParameter("Tekst", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Add_Info_Notification", linijaIdParameter, tekstParameter);
        }
    
        public virtual int Add_Discount(Nullable<double> discountNumber, Nullable<System.DateTime> dateExpiracy)
        {
            var discountNumberParameter = discountNumber.HasValue ?
                new ObjectParameter("discountNumber", discountNumber) :
                new ObjectParameter("discountNumber", typeof(double));
    
            var dateExpiracyParameter = dateExpiracy.HasValue ?
                new ObjectParameter("dateExpiracy", dateExpiracy) :
                new ObjectParameter("dateExpiracy", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Add_Discount", discountNumberParameter, dateExpiracyParameter);
        }
    
        public virtual int Add_Discount_On_Line(Nullable<int> discountId, Nullable<int> lineId, string text)
        {
            var discountIdParameter = discountId.HasValue ?
                new ObjectParameter("DiscountId", discountId) :
                new ObjectParameter("DiscountId", typeof(int));
    
            var lineIdParameter = lineId.HasValue ?
                new ObjectParameter("LineId", lineId) :
                new ObjectParameter("LineId", typeof(int));
    
            var textParameter = text != null ?
                new ObjectParameter("Text", text) :
                new ObjectParameter("Text", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Add_Discount_On_Line", discountIdParameter, lineIdParameter, textParameter);
        }
    
        public virtual ObjectResult<usp_Get_All_Notifications_Result> Get_All_Notifications()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_Get_All_Notifications_Result>("Get_All_Notifications");
        }
    
        public virtual int Edit_Notification(string tableName, string text, Nullable<int> id)
        {
            var tableNameParameter = tableName != null ?
                new ObjectParameter("tableName", tableName) :
                new ObjectParameter("tableName", typeof(string));
    
            var textParameter = text != null ?
                new ObjectParameter("Text", text) :
                new ObjectParameter("Text", typeof(string));
    
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Edit_Notification", tableNameParameter, textParameter, idParameter);
        }
    
        public virtual ObjectResult<usp_Get_Lines_With_Traveler_Result> Get_Lines_With_Traveler()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_Get_Lines_With_Traveler_Result>("Get_Lines_With_Traveler");
        }
    
        public virtual ObjectResult<usp_Get_All_Cities_Result> Get_All_Cities()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_Get_All_Cities_Result>("Get_All_Cities");
        }
    
        public virtual int Make_Relation_Un_Active(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Make_Relation_Un_Active", idParameter);
        }
    
        public virtual ObjectResult<usp_Get_Travelers_Result> Get_Travelers()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_Get_Travelers_Result>("Get_Travelers");
        }
    
        public virtual int Edit_Relation(Nullable<int> id, Nullable<int> startCityId, Nullable<int> destinationCityId, string name, Nullable<int> travelerId, string lineType, string startTime)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var startCityIdParameter = startCityId.HasValue ?
                new ObjectParameter("startCityId", startCityId) :
                new ObjectParameter("startCityId", typeof(int));
    
            var destinationCityIdParameter = destinationCityId.HasValue ?
                new ObjectParameter("destinationCityId", destinationCityId) :
                new ObjectParameter("destinationCityId", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var travelerIdParameter = travelerId.HasValue ?
                new ObjectParameter("travelerId", travelerId) :
                new ObjectParameter("travelerId", typeof(int));
    
            var lineTypeParameter = lineType != null ?
                new ObjectParameter("lineType", lineType) :
                new ObjectParameter("lineType", typeof(string));
    
            var startTimeParameter = startTime != null ?
                new ObjectParameter("startTime", startTime) :
                new ObjectParameter("startTime", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Edit_Relation", idParameter, startCityIdParameter, destinationCityIdParameter, nameParameter, travelerIdParameter, lineTypeParameter, startTimeParameter);
        }
    
        public virtual int Add_Relation(Nullable<int> startCityId, Nullable<int> destinationCityId, string name, Nullable<int> travelerId, string typeOfLine, string startTime)
        {
            var startCityIdParameter = startCityId.HasValue ?
                new ObjectParameter("startCityId", startCityId) :
                new ObjectParameter("startCityId", typeof(int));
    
            var destinationCityIdParameter = destinationCityId.HasValue ?
                new ObjectParameter("destinationCityId", destinationCityId) :
                new ObjectParameter("destinationCityId", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var travelerIdParameter = travelerId.HasValue ?
                new ObjectParameter("TravelerId", travelerId) :
                new ObjectParameter("TravelerId", typeof(int));
    
            var typeOfLineParameter = typeOfLine != null ?
                new ObjectParameter("typeOfLine", typeOfLine) :
                new ObjectParameter("typeOfLine", typeof(string));
    
            var startTimeParameter = startTime != null ?
                new ObjectParameter("startTime", startTime) :
                new ObjectParameter("startTime", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Add_Relation", startCityIdParameter, destinationCityIdParameter, nameParameter, travelerIdParameter, typeOfLineParameter, startTimeParameter);
        }
    
        public virtual ObjectResult<usp_Get_Cities_That_Line_Passes_Result> Get_Cities_That_Line_Passes(Nullable<int> lineId)
        {
            var lineIdParameter = lineId.HasValue ?
                new ObjectParameter("LineId", lineId) :
                new ObjectParameter("LineId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_Get_Cities_That_Line_Passes_Result>("Get_Cities_That_Line_Passes", lineIdParameter);
        }
    
        public virtual int Add_City_That_Line_Pass(Nullable<int> lineId, Nullable<double> priceFromStart, Nullable<int> cityId, string comingTime, Nullable<bool> isDeleted, Nullable<double> priceFromCurent, Nullable<bool> typeCard)
        {
            var lineIdParameter = lineId.HasValue ?
                new ObjectParameter("lineId", lineId) :
                new ObjectParameter("lineId", typeof(int));
    
            var priceFromStartParameter = priceFromStart.HasValue ?
                new ObjectParameter("priceFromStart", priceFromStart) :
                new ObjectParameter("priceFromStart", typeof(double));
    
            var cityIdParameter = cityId.HasValue ?
                new ObjectParameter("cityId", cityId) :
                new ObjectParameter("cityId", typeof(int));
    
            var comingTimeParameter = comingTime != null ?
                new ObjectParameter("comingTime", comingTime) :
                new ObjectParameter("comingTime", typeof(string));
    
            var isDeletedParameter = isDeleted.HasValue ?
                new ObjectParameter("isDeleted", isDeleted) :
                new ObjectParameter("isDeleted", typeof(bool));
    
            var priceFromCurentParameter = priceFromCurent.HasValue ?
                new ObjectParameter("priceFromCurent", priceFromCurent) :
                new ObjectParameter("priceFromCurent", typeof(double));
    
            var typeCardParameter = typeCard.HasValue ?
                new ObjectParameter("typeCard", typeCard) :
                new ObjectParameter("typeCard", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Add_City_That_Line_Pass", lineIdParameter, priceFromStartParameter, cityIdParameter, comingTimeParameter, isDeletedParameter, priceFromCurentParameter, typeCardParameter);
        }
    
        public virtual int Update_City_That_Line_Pass(Nullable<int> lineId, Nullable<int> cityPassingLineId, Nullable<double> priceFromStart, Nullable<int> cityId, string comingTime, Nullable<bool> isDeleted, Nullable<double> priceFromCurent, Nullable<bool> typeCard)
        {
            var lineIdParameter = lineId.HasValue ?
                new ObjectParameter("lineId", lineId) :
                new ObjectParameter("lineId", typeof(int));
    
            var cityPassingLineIdParameter = cityPassingLineId.HasValue ?
                new ObjectParameter("CityPassingLineId", cityPassingLineId) :
                new ObjectParameter("CityPassingLineId", typeof(int));
    
            var priceFromStartParameter = priceFromStart.HasValue ?
                new ObjectParameter("priceFromStart", priceFromStart) :
                new ObjectParameter("priceFromStart", typeof(double));
    
            var cityIdParameter = cityId.HasValue ?
                new ObjectParameter("cityId", cityId) :
                new ObjectParameter("cityId", typeof(int));
    
            var comingTimeParameter = comingTime != null ?
                new ObjectParameter("comingTime", comingTime) :
                new ObjectParameter("comingTime", typeof(string));
    
            var isDeletedParameter = isDeleted.HasValue ?
                new ObjectParameter("isDeleted", isDeleted) :
                new ObjectParameter("isDeleted", typeof(bool));
    
            var priceFromCurentParameter = priceFromCurent.HasValue ?
                new ObjectParameter("priceFromCurent", priceFromCurent) :
                new ObjectParameter("priceFromCurent", typeof(double));
    
            var typeCardParameter = typeCard.HasValue ?
                new ObjectParameter("typeCard", typeCard) :
                new ObjectParameter("typeCard", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Update_City_That_Line_Pass", lineIdParameter, cityPassingLineIdParameter, priceFromStartParameter, cityIdParameter, comingTimeParameter, isDeletedParameter, priceFromCurentParameter, typeCardParameter);
        }
    
        public virtual int Delete_City_That_Line_Pass(Nullable<int> cityLineId)
        {
            var cityLineIdParameter = cityLineId.HasValue ?
                new ObjectParameter("cityLineId", cityLineId) :
                new ObjectParameter("cityLineId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Delete_City_That_Line_Pass", cityLineIdParameter);
        }
    
        public virtual ObjectResult<usp_Get_Types_Of_Buses_Result> Get_Types_Of_Buses()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_Get_Types_Of_Buses_Result>("Get_Types_Of_Buses");
        }
    
        public virtual ObjectResult<usp_Search_Buses_Result> Search_Buses(Nullable<int> travelerId, Nullable<int> typeOfBus)
        {
            var travelerIdParameter = travelerId.HasValue ?
                new ObjectParameter("travelerId", travelerId) :
                new ObjectParameter("travelerId", typeof(int));
    
            var typeOfBusParameter = typeOfBus.HasValue ?
                new ObjectParameter("typeOfBus", typeOfBus) :
                new ObjectParameter("typeOfBus", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_Search_Buses_Result>("Search_Buses", travelerIdParameter, typeOfBusParameter);
        }
    
        public virtual int Add_Coming_Bus_On_Station(Nullable<int> employeeId, Nullable<int> stationId, string timeOfDelay, Nullable<System.DateTime> timeOfComingOnStation, Nullable<bool> isLateOnStation)
        {
            var employeeIdParameter = employeeId.HasValue ?
                new ObjectParameter("employeeId", employeeId) :
                new ObjectParameter("employeeId", typeof(int));
    
            var stationIdParameter = stationId.HasValue ?
                new ObjectParameter("stationId", stationId) :
                new ObjectParameter("stationId", typeof(int));
    
            var timeOfDelayParameter = timeOfDelay != null ?
                new ObjectParameter("timeOfDelay", timeOfDelay) :
                new ObjectParameter("timeOfDelay", typeof(string));
    
            var timeOfComingOnStationParameter = timeOfComingOnStation.HasValue ?
                new ObjectParameter("timeOfComingOnStation", timeOfComingOnStation) :
                new ObjectParameter("timeOfComingOnStation", typeof(System.DateTime));
    
            var isLateOnStationParameter = isLateOnStation.HasValue ?
                new ObjectParameter("isLateOnStation", isLateOnStation) :
                new ObjectParameter("isLateOnStation", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Add_Coming_Bus_On_Station", employeeIdParameter, stationIdParameter, timeOfDelayParameter, timeOfComingOnStationParameter, isLateOnStationParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> Get_Station_By_City(Nullable<int> cityId)
        {
            var cityIdParameter = cityId.HasValue ?
                new ObjectParameter("cityId", cityId) :
                new ObjectParameter("cityId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("Get_Station_By_City", cityIdParameter);
        }
    
        public virtual int usp_mobile_Add_User(string username, string hash, string name, string surname, Nullable<System.DateTime> datetimebirth, string jobtitle, string email, Nullable<bool> isValid, Nullable<int> userRole, string discriminator, string gender, string salt)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var hashParameter = hash != null ?
                new ObjectParameter("hash", hash) :
                new ObjectParameter("hash", typeof(string));
    
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var surnameParameter = surname != null ?
                new ObjectParameter("surname", surname) :
                new ObjectParameter("surname", typeof(string));
    
            var datetimebirthParameter = datetimebirth.HasValue ?
                new ObjectParameter("datetimebirth", datetimebirth) :
                new ObjectParameter("datetimebirth", typeof(System.DateTime));
    
            var jobtitleParameter = jobtitle != null ?
                new ObjectParameter("jobtitle", jobtitle) :
                new ObjectParameter("jobtitle", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var isValidParameter = isValid.HasValue ?
                new ObjectParameter("isValid", isValid) :
                new ObjectParameter("isValid", typeof(bool));
    
            var userRoleParameter = userRole.HasValue ?
                new ObjectParameter("userRole", userRole) :
                new ObjectParameter("userRole", typeof(int));
    
            var discriminatorParameter = discriminator != null ?
                new ObjectParameter("discriminator", discriminator) :
                new ObjectParameter("discriminator", typeof(string));
    
            var genderParameter = gender != null ?
                new ObjectParameter("gender", gender) :
                new ObjectParameter("gender", typeof(string));
    
            var saltParameter = salt != null ?
                new ObjectParameter("salt", salt) :
                new ObjectParameter("salt", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_mobile_Add_User", usernameParameter, hashParameter, nameParameter, surnameParameter, datetimebirthParameter, jobtitleParameter, emailParameter, isValidParameter, userRoleParameter, discriminatorParameter, genderParameter, saltParameter);
        }
    
        public virtual ObjectResult<usp_mobile_Get_User_Result> usp_mobile_Get_User(string username)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_mobile_Get_User_Result>("usp_mobile_Get_User", usernameParameter);
        }
    
        public virtual ObjectResult<usp_mobile_Search_Lines_Result> usp_mobile_Search_Lines(string startStation, string endStation, string traveler, string startTime, string timeOfComing)
        {
            var startStationParameter = startStation != null ?
                new ObjectParameter("startStation", startStation) :
                new ObjectParameter("startStation", typeof(string));
    
            var endStationParameter = endStation != null ?
                new ObjectParameter("endStation", endStation) :
                new ObjectParameter("endStation", typeof(string));
    
            var travelerParameter = traveler != null ?
                new ObjectParameter("traveler", traveler) :
                new ObjectParameter("traveler", typeof(string));
    
            var startTimeParameter = startTime != null ?
                new ObjectParameter("startTime", startTime) :
                new ObjectParameter("startTime", typeof(string));
    
            var timeOfComingParameter = timeOfComing != null ?
                new ObjectParameter("timeOfComing", timeOfComing) :
                new ObjectParameter("timeOfComing", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_mobile_Search_Lines_Result>("usp_mobile_Search_Lines", startStationParameter, endStationParameter, travelerParameter, startTimeParameter, timeOfComingParameter);
        }
    
        public virtual int Add_Bus_Picture(byte[] picture, Nullable<int> busId)
        {
            var pictureParameter = picture != null ?
                new ObjectParameter("picture", picture) :
                new ObjectParameter("picture", typeof(byte[]));
    
            var busIdParameter = busId.HasValue ?
                new ObjectParameter("busId", busId) :
                new ObjectParameter("busId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Add_Bus_Picture", pictureParameter, busIdParameter);
        }
    
        public virtual ObjectResult<usp_mobile_Get_Buses_Information_Result> usp_mobile_Get_Buses_Information(Nullable<int> lineId)
        {
            var lineIdParameter = lineId.HasValue ?
                new ObjectParameter("lineId", lineId) :
                new ObjectParameter("lineId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_mobile_Get_Buses_Information_Result>("usp_mobile_Get_Buses_Information", lineIdParameter);
        }
    
        public virtual ObjectResult<usp_mobile_Get_Available_Places_Bus_At_Date_Result> usp_mobile_Get_Available_Places_Bus_At_Date(string dateReservation)
        {
            var dateReservationParameter = dateReservation != null ?
                new ObjectParameter("dateReservation", dateReservation) :
                new ObjectParameter("dateReservation", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_mobile_Get_Available_Places_Bus_At_Date_Result>("usp_mobile_Get_Available_Places_Bus_At_Date", dateReservationParameter);
        }
    
        public virtual ObjectResult<usp_mobile_Get_Relation_Offer_Information_Result> usp_mobile_Get_Relation_Offer_Information(Nullable<int> offerId)
        {
            var offerIdParameter = offerId.HasValue ?
                new ObjectParameter("offerId", offerId) :
                new ObjectParameter("offerId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_mobile_Get_Relation_Offer_Information_Result>("usp_mobile_Get_Relation_Offer_Information", offerIdParameter);
        }
    
        public virtual ObjectResult<usp_mobile_Get_User_Credit_Cards_Result> usp_mobile_Get_User_Credit_Cards(Nullable<int> userId)
        {
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("userId", userId) :
                new ObjectParameter("userId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_mobile_Get_User_Credit_Cards_Result>("usp_mobile_Get_User_Credit_Cards", userIdParameter);
        }
    
        public virtual ObjectResult<Nullable<decimal>> usp_mobile_Add_User_Travel(Nullable<bool> cardActive, string ticketRandomNumber, string numberOfSeat, Nullable<System.DateTime> datetimeOfTravel, Nullable<int> locationVisitingId, Nullable<int> cardTypeId)
        {
            var cardActiveParameter = cardActive.HasValue ?
                new ObjectParameter("cardActive", cardActive) :
                new ObjectParameter("cardActive", typeof(bool));
    
            var ticketRandomNumberParameter = ticketRandomNumber != null ?
                new ObjectParameter("ticketRandomNumber", ticketRandomNumber) :
                new ObjectParameter("ticketRandomNumber", typeof(string));
    
            var numberOfSeatParameter = numberOfSeat != null ?
                new ObjectParameter("numberOfSeat", numberOfSeat) :
                new ObjectParameter("numberOfSeat", typeof(string));
    
            var datetimeOfTravelParameter = datetimeOfTravel.HasValue ?
                new ObjectParameter("datetimeOfTravel", datetimeOfTravel) :
                new ObjectParameter("datetimeOfTravel", typeof(System.DateTime));
    
            var locationVisitingIdParameter = locationVisitingId.HasValue ?
                new ObjectParameter("locationVisitingId", locationVisitingId) :
                new ObjectParameter("locationVisitingId", typeof(int));
    
            var cardTypeIdParameter = cardTypeId.HasValue ?
                new ObjectParameter("cardTypeId", cardTypeId) :
                new ObjectParameter("cardTypeId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("usp_mobile_Add_User_Travel", cardActiveParameter, ticketRandomNumberParameter, numberOfSeatParameter, datetimeOfTravelParameter, locationVisitingIdParameter, cardTypeIdParameter);
        }
    
        public virtual ObjectResult<Nullable<decimal>> usp_mobile_Add_User_Transaction(Nullable<System.DateTime> dateShopping, string transactionNumber, string status, Nullable<bool> canceled, Nullable<int> userId, Nullable<int> cardId)
        {
            var dateShoppingParameter = dateShopping.HasValue ?
                new ObjectParameter("dateShopping", dateShopping) :
                new ObjectParameter("dateShopping", typeof(System.DateTime));
    
            var transactionNumberParameter = transactionNumber != null ?
                new ObjectParameter("transactionNumber", transactionNumber) :
                new ObjectParameter("transactionNumber", typeof(string));
    
            var statusParameter = status != null ?
                new ObjectParameter("status", status) :
                new ObjectParameter("status", typeof(string));
    
            var canceledParameter = canceled.HasValue ?
                new ObjectParameter("canceled", canceled) :
                new ObjectParameter("canceled", typeof(bool));
    
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("userId", userId) :
                new ObjectParameter("userId", typeof(int));
    
            var cardIdParameter = cardId.HasValue ?
                new ObjectParameter("cardId", cardId) :
                new ObjectParameter("cardId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("usp_mobile_Add_User_Transaction", dateShoppingParameter, transactionNumberParameter, statusParameter, canceledParameter, userIdParameter, cardIdParameter);
        }
    
        public virtual int usp_mobile_Add_User_Transaction_Detail(Nullable<int> transactionId, Nullable<int> busCard, Nullable<int> quantityOfCards, Nullable<float> price)
        {
            var transactionIdParameter = transactionId.HasValue ?
                new ObjectParameter("transactionId", transactionId) :
                new ObjectParameter("transactionId", typeof(int));
    
            var busCardParameter = busCard.HasValue ?
                new ObjectParameter("busCard", busCard) :
                new ObjectParameter("busCard", typeof(int));
    
            var quantityOfCardsParameter = quantityOfCards.HasValue ?
                new ObjectParameter("quantityOfCards", quantityOfCards) :
                new ObjectParameter("quantityOfCards", typeof(int));
    
            var priceParameter = price.HasValue ?
                new ObjectParameter("price", price) :
                new ObjectParameter("price", typeof(float));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_mobile_Add_User_Transaction_Detail", transactionIdParameter, busCardParameter, quantityOfCardsParameter, priceParameter);
        }
    
        public virtual ObjectResult<usp_mobile_Get_All_User_Transactions_Result> usp_mobile_Get_All_User_Transactions(Nullable<int> userId)
        {
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("userId", userId) :
                new ObjectParameter("userId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_mobile_Get_All_User_Transactions_Result>("usp_mobile_Get_All_User_Transactions", userIdParameter);
        }
    
        public virtual int usp_mobile_Cancel_Transaction(Nullable<int> transactionId)
        {
            var transactionIdParameter = transactionId.HasValue ?
                new ObjectParameter("transactionId", transactionId) :
                new ObjectParameter("transactionId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_mobile_Cancel_Transaction", transactionIdParameter);
        }
    
        public virtual ObjectResult<usp_mobile_Get_All_User_Finished_Travels_Result> usp_mobile_Get_All_User_Finished_Travels(Nullable<int> userId)
        {
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("userId", userId) :
                new ObjectParameter("userId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_mobile_Get_All_User_Finished_Travels_Result>("usp_mobile_Get_All_User_Finished_Travels", userIdParameter);
        }
    
        public virtual int usp_mobile_Add_User_Recension(Nullable<int> ticketId, Nullable<int> userId, Nullable<double> rateValue, string rateString)
        {
            var ticketIdParameter = ticketId.HasValue ?
                new ObjectParameter("ticketId", ticketId) :
                new ObjectParameter("ticketId", typeof(int));
    
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("userId", userId) :
                new ObjectParameter("userId", typeof(int));
    
            var rateValueParameter = rateValue.HasValue ?
                new ObjectParameter("rateValue", rateValue) :
                new ObjectParameter("rateValue", typeof(double));
    
            var rateStringParameter = rateString != null ?
                new ObjectParameter("rateString", rateString) :
                new ObjectParameter("rateString", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_mobile_Add_User_Recension", ticketIdParameter, userIdParameter, rateValueParameter, rateStringParameter);
        }
    
        public virtual ObjectResult<usp_mobile_Get_Line_Discounts_Result> usp_mobile_Get_Line_Discounts(Nullable<int> lineId)
        {
            var lineIdParameter = lineId.HasValue ?
                new ObjectParameter("lineId", lineId) :
                new ObjectParameter("lineId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_mobile_Get_Line_Discounts_Result>("usp_mobile_Get_Line_Discounts", lineIdParameter);
        }
    
        public virtual ObjectResult<usp_mobile_Recommender_Load_Rates_Result> usp_mobile_Recommender_Load_Rates(Nullable<int> relationId)
        {
            var relationIdParameter = relationId.HasValue ?
                new ObjectParameter("relationId", relationId) :
                new ObjectParameter("relationId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_mobile_Recommender_Load_Rates_Result>("usp_mobile_Recommender_Load_Rates", relationIdParameter);
        }
    
        public virtual ObjectResult<usp_mobile_Recommnder_Load_Relations_Different_Than_Current_Result> usp_mobile_Recommnder_Load_Relations_Different_Than_Current(Nullable<int> relationId)
        {
            var relationIdParameter = relationId.HasValue ?
                new ObjectParameter("relationId", relationId) :
                new ObjectParameter("relationId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_mobile_Recommnder_Load_Relations_Different_Than_Current_Result>("usp_mobile_Recommnder_Load_Relations_Different_Than_Current", relationIdParameter);
        }
    
        public virtual ObjectResult<usp_Get_Cities_That_Line_Passes_Result> usp_mobile_Get_Cite_That_Line_Pass_By_Id(Nullable<int> relationId)
        {
            var relationIdParameter = relationId.HasValue ?
                new ObjectParameter("relationId", relationId) :
                new ObjectParameter("relationId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_Get_Cities_That_Line_Passes_Result>("usp_mobile_Get_Cite_That_Line_Pass_By_Id", relationIdParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> usp_mobile_Check_For_Recension_It_Exists(Nullable<int> ticketId)
        {
            var ticketIdParameter = ticketId.HasValue ?
                new ObjectParameter("ticketId", ticketId) :
                new ObjectParameter("ticketId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("usp_mobile_Check_For_Recension_It_Exists", ticketIdParameter);
        }
    
        public virtual ObjectResult<usp_Get_Line_Earnings_Result> Get_Line_Earnings()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_Get_Line_Earnings_Result>("Get_Line_Earnings");
        }
    
        public virtual ObjectResult<usp_Get_Reservation_Counter_On_Line_Result> Get_Reservation_Counter_On_Line()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_Get_Reservation_Counter_On_Line_Result>("Get_Reservation_Counter_On_Line");
        }
    
        public virtual int usp_Add_Bus(Nullable<int> busSeats, string manufacturer, Nullable<int> typeOfBusId, string registration)
        {
            var busSeatsParameter = busSeats.HasValue ?
                new ObjectParameter("busSeats", busSeats) :
                new ObjectParameter("busSeats", typeof(int));
    
            var manufacturerParameter = manufacturer != null ?
                new ObjectParameter("manufacturer", manufacturer) :
                new ObjectParameter("manufacturer", typeof(string));
    
            var typeOfBusIdParameter = typeOfBusId.HasValue ?
                new ObjectParameter("typeOfBusId", typeOfBusId) :
                new ObjectParameter("typeOfBusId", typeof(int));
    
            var registrationParameter = registration != null ?
                new ObjectParameter("registration", registration) :
                new ObjectParameter("registration", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_Add_Bus", busSeatsParameter, manufacturerParameter, typeOfBusIdParameter, registrationParameter);
        }
    
        public virtual ObjectResult<Get_All_Bus_Names_Result> Get_All_Bus_Names()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Get_All_Bus_Names_Result>("Get_All_Bus_Names");
        }
    }
}