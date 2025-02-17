﻿using DemoLibrary.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class BusinessLogic : IBusinessLogic 
    {
        private readonly ILogger _logger;
        private readonly IDataAccess _dataAccess;

        public BusinessLogic(ILogger _logger, IDataAccess _dataAccess)
        {
            this._logger = _logger;
            this._dataAccess = _dataAccess;
        }

        public void ProcessData()
        {

            _logger.Log("Starting the processing of data.");
            Console.WriteLine("Processing the data");
            _dataAccess.LoadData();
            _dataAccess.SaveData("ProcessedInfo");
            _logger.Log("Finished processing of the data.");
        }
    }
}
