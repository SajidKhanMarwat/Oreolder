﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Oreolder.Models;

public partial class Customer
{
    public long Id { get; set; }

    public Guid CustomerGuid { get; set; }

    public string Salutation { get; set; }

    public decimal? NteAmount { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string MiddleName { get; set; }

    public int CustomerType { get; set; }

    public string WebSite { get; set; }

    public string Email { get; set; }

    public string Ivrnumber { get; set; }

    public string Ivrpin { get; set; }

    public bool Deleted { get; set; }

    public bool TaxExempt { get; set; }

    public string TaxExemptNumber { get; set; }

    public bool Active { get; set; }

    public DateTime CreatedOn { get; set; }

    public long CreatedByUserId { get; set; }

    public DateTime LastUpdateOn { get; set; }

    public long LastUpdatedByUserId { get; set; }

    public string Notes { get; set; }

    public string WrapupNotes { get; set; }

    public string CustomerDescription { get; set; }

    public int? PreferedCommunicationMethod { get; set; }

    public string CustomerRepresentative { get; set; }

    public string NotificationFirstName { get; set; }

    public string NotificationLastName { get; set; }

    public string NotificationTitle { get; set; }

    public string NotificationEmail { get; set; }

    public string OtherFirstName { get; set; }

    public string OtherLastName { get; set; }

    public string OtherTitle { get; set; }

    public string OtherEmail { get; set; }

    public bool? UpdateOnCreated { get; set; }

    public bool? UpdateOnCompleted { get; set; }

    public bool? UpdateOnDisptched { get; set; }

    public bool? UpdateOnAssigned { get; set; }

    public bool? UpdateOnReturn { get; set; }

    public bool? UpdateOnPartsOnOrder { get; set; }

    public bool? UpdateOnDelayed { get; set; }

    public bool? UpdateInCustomerPortal { get; set; }

    public bool? UpdateInCustomerEmail { get; set; }

    public decimal? MarkupOnParts { get; set; }

    public decimal? DiscountOnParts { get; set; }

    public string SpecialInstructions { get; set; }

    public string LoginPassword { get; set; }

    public bool? CreditWorthy { get; set; }

    public bool AutoUpdates { get; set; }

    public bool ManualUpdates { get; set; }

    public decimal? TripCharges { get; set; }

    public decimal? HourlyLabour { get; set; }

    public string UrgentNoteDetails { get; set; }

    public bool HasUrgentNote { get; set; }

    public bool StartEndDate { get; set; }

    public string AmfirstName { get; set; }

    public string AmlastName { get; set; }

    public string Amemail { get; set; }

    public bool? InvoiceChecked { get; set; }

    public bool? WorkOrderChecked { get; set; }

    public bool? SignOffChecked { get; set; }

    public bool? HasUserAccess { get; set; }

    public bool? NeedInvoiceApproval { get; set; }

    public int? OfficeId { get; set; }

    public string SubscriberId { get; set; }

    public bool? AlertTrigerEmailCustomer { get; set; }

    public int? CustomerPriceBookId { get; set; }

    public bool? IsAccountsInPlay { get; set; }

    public string AccountsInPlayReason { get; set; }

    public DateTime? AddedOnAccountsInPlay { get; set; }

    public int? EndOfLife { get; set; }

    public bool? IsPochecked { get; set; }

    public bool? IsNtechecked { get; set; }

    public virtual ICollection<Job> Job { get; set; } = new List<Job>();

    public virtual ICollection<User> User { get; set; } = new List<User>();
}