namespace Course.Library.ObjectSettings;

public class CommandDispatcher
{
    private readonly IServiceProvider _serviceProvider;

    public CommandDispatcher(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public void Send<TCommand>(TCommand command) where TCommand : ICommand
    {
        var handlerType = typeof(ICommandHandler<>).MakeGenericType(command.GetType());

        var handler = _serviceProvider.GetService(handlerType);

        if (handler == null)
            throw new InvalidOperationException($"Не знайдено обробника для команди типу {command.GetType().Name}.");

        ((ICommandHandler<TCommand>)handler).Handle(command);
    }
}

public enum Settings { None, Name, Artists, Icon, AlbumName, Lyrics, Genres, AddSong, RemoveSong }
