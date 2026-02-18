// DESAFIO: Sistema de Notificações Multi-Canal
// PROBLEMA: Uma aplicação de e-commerce precisa enviar notificações por diferentes canais
// (Email, SMS, Push, WhatsApp) dependendo da preferência do cliente e tipo de notificação
// O código atual viola o Open/Closed Principle ao usar condicionais para criar notificações

namespace DesignPatternChallenge_FactoryMethod;

// Contexto: Sistema de notificações que envia mensagens para clientes
// Cada tipo de notificação tem requisitos e formatação diferentes

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== Sistema de Notificações ===\n");

        var manager = new NotificationManager();

        // Cliente 1 prefere Email
        var emailCreator = new EmailNotificationCreator(
            recipient: "cliente@email.com",
            subject: "Confirmação de Pedido",
            body: "Seu pedido 12345 foi confirmado!",
            isHtml: true);
        manager.SendNotification(emailCreator);
        Console.WriteLine();

        // Cliente 2 prefere SMS
        var smsCreator = new SmsNotificationCreator(
            phoneNumber: "+5511999999999",
            message: "Pedido 12346 confirmado!");
        manager.SendNotification(smsCreator);
        Console.WriteLine();

        // Cliente 3 prefere Push
        var pushCreator = new PushNotificationCreator(
            deviceToken: "device-token-abc123",
            title: "Pedido Enviado",
            message: "Rastreamento: BR123456789",
            badge: 1);
        manager.SendNotification(pushCreator);
        Console.WriteLine();

        // Cliente 4 prefere WhatsApp
        var whatsappCreator = new WhatsAppNotificationCreator(
            phoneNumber: "+5511888888888",
            message: "💰 Você tem um pagamento pendente de R$ 150,00",
            useTemplate: true);
        manager.SendNotification(whatsappCreator);
    }
}