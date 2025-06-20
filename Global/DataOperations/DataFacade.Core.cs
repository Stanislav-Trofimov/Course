using Course.Directory.Data;
using Course.Library.Data;
using Course.Library.ObjectSettings;

namespace Course.Global.DataOperations;

public partial class DataFacade // Core частина
{
    private readonly DirectoryData _directoryData;
    private readonly LibraryData _libraryData;
    private readonly CommandDispatcher _dispatcher;

    public DataFacade(CommandDispatcher dispatcher)
    {
        _directoryData = new DirectoryData();
        _libraryData = new LibraryData();

        _dispatcher = dispatcher;
    }
}
