﻿namespace Notification.Infrastructure.Common.Notification.Settings;

public class SmtpEmailSenderSettings
{
    public string Host { get; set; } = default!;

    public int Port { get; set; }

    public string CredentialAddress { get; set; } = default!;

    public string Password { get; set; } = default!;
}
