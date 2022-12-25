using System;
using DemoLibrary.Utilities;

namespace DemoLibrary
{
    public class BetterBusinessLogic:IBusinessLogic
    {
        private readonly ILogger _logger;
        private readonly IDataAccess _dataAccess;

        public BetterBusinessLogic(ILogger _logger, IDataAccess _dataAccess)
        {
            this._logger = _logger;
            this._dataAccess = _dataAccess;
        }

        public void ProcessData()
        {

            _logger.Log("Starting the processing of data.");
            Console.WriteLine("Processing the data");
            Console.WriteLine();

            _dataAccess.LoadData();
            _dataAccess.SaveData("ProcessedInfo");

            Console.WriteLine();
            _logger.Log("Finished processing of the data.");
        }
    }
}
