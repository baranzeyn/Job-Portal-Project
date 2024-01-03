﻿using System;
using System.Collections.Generic;

namespace Job_Portal_Project.Models;

public partial class Offer
{
    public int OfferId { get; set; }

    public int? JobId { get; set; }

    public int? ApplicantId { get; set; }

    public decimal OfferAmount { get; set; }

    public int OfferDuration { get; set; }

    public DateTime? OfferDate { get; set; }

    public string? Status { get; set; }

    public virtual User? Applicant { get; set; }

    public virtual Application? Application { get; set; }

    public virtual Job? Job { get; set; }
}