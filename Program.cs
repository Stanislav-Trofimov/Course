using Course.Global.DataOperations;
using Course.Library.Objects;
using Course.Library.ObjectSettings;
using Course.Render;
using Microsoft.Extensions.DependencyInjection;
using System.Text;

namespace Course;

internal class Program
{
    [STAThread]
    public static void Main()
    {
        Console.OutputEncoding = UnicodeEncoding.Unicode;

        DataFacade facade = InitializeDI();

        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new FormFeed(facade));

        facade.SaveProgramData();
    }

    private static DataFacade InitializeDI()
    {
        ServiceCollection services = new ServiceCollection();

        services.AddSingleton<ReceiverFactory<CustomSong>>();
        services.AddSingleton<ReceiverFactory<Playlist>>();

        services.AddSingleton<DataFacade>();
        services.AddSingleton<CommandDispatcher>();

        // Жорстка зв'язка типів
        services.AddTransient<ICommandHandler<UpdatePropertyCommand<Playlist>>, UpdatePropertyCommandHandler<Playlist>>();
        services.AddTransient<ICommandHandler<UpdatePropertyCommand<CustomSong>>, UpdatePropertyCommandHandler<CustomSong>>();

        services.AddTransient<ICommandHandler<UpdateGenresCommand<Playlist>>, UpdateGenresCommandHandler<Playlist>>();
        services.AddTransient<ICommandHandler<UpdateGenresCommand<CustomSong>>, UpdateGenresCommandHandler<CustomSong>>();

        services.AddTransient<ICommandHandler<AddSongToPlaylistCommand>, AddSongToPlaylistCommandHandler>();
        services.AddTransient<ICommandHandler<RemoveSongToPlaylistCommand>, RemoveSongToPlaylistCommandHandler>();
        // Жорстка зв'язка типів

        ServiceProvider provider = services.BuildServiceProvider();

        return provider.GetRequiredService<DataFacade>();
    }
}
