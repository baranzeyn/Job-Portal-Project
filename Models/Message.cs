using System;
using System.Collections.Generic;

namespace Job_Portal_Project.Models;

public partial class Message
{
    public int MessageId { get; set; }

    public string SenderName { get; set; } = null!;

    public string SenderEmail { get; set; } = null!;

    public string SenderRole { get; set; } = null!;

    public string MessageText { get; set; } = null!;

    public DateTime? Timestamp { get; set; }

    public string? SenderNum { get; set; }
}
