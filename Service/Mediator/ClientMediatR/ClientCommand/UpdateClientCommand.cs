public sealed record UpdateClientCommand(ClientDto clientDto):ICommand<bool>;