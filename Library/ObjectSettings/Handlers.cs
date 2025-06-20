using Course.Global.Objects;
using Course.Library.Objects;

namespace Course.Library.ObjectSettings;

public interface ICommandHandler<TCommand> where TCommand : ICommand
{
    void Handle(TCommand command);
}

class UpdatePropertyCommandHandler<TObject> : ICommandHandler<UpdatePropertyCommand<TObject>> where TObject : CustomObject
{
    private readonly ReceiverFactory<TObject> _factory;

    public UpdatePropertyCommandHandler(ReceiverFactory<TObject> factory)
    {
        _factory = factory;
    }

    public void Handle(UpdatePropertyCommand<TObject> command)
    {
        IReceiver<TObject, string> receiver = _factory.GetStrategy<string>(command.Settings);
        receiver.Action(command.Target, command.Value);
    }
}

class UpdateGenresCommandHandler<TObject> : ICommandHandler<UpdateGenresCommand<TObject>> where TObject : CustomObject
{
    private readonly ReceiverFactory<TObject> _factory;

    public UpdateGenresCommandHandler(ReceiverFactory<TObject> factory)
    {
        _factory = factory;
    }

    public void Handle(UpdateGenresCommand<TObject> command)
    {
        IReceiver<TObject, List<string>> receiver = _factory.GetStrategy<List<string>>(command.Settings);
        receiver.Action(command.Target, command.Value);
    }
}

class AddSongToPlaylistCommandHandler : ICommandHandler<AddSongToPlaylistCommand>
{
    public void Handle(AddSongToPlaylistCommand command)
    {
        IReceiver<Playlist, ISong> receiver = new AddSongReceiver();
        receiver.Action(command.Target, command.Value);
    }
}

class RemoveSongToPlaylistCommandHandler : ICommandHandler<RemoveSongToPlaylistCommand>
{
    public void Handle(RemoveSongToPlaylistCommand command)
    {
        IReceiver<Playlist, ISong> receiver = new RemoveSongReceiver();
        receiver.Action(command.Target, command.Value);
    }
}
