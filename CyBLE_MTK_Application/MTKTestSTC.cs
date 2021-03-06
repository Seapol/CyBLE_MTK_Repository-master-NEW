using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.IO.Ports;
using System.Threading;
using System.Text.RegularExpressions;


namespace CyBLE_MTK_Application
{
    public class MTKTestSTC : MTKTest
    {
        public int PacketCount;
        public int DelayPerCommand = 20 + CyBLE_MTK_Application.Properties.Settings.Default.DelayPerCommandSTC_Additional;//, msPerSecond = 1000;


        public MTKTestSTC() : base()
        {
            Init();
        }

        public MTKTestSTC(LogManager Logger)
            : base(Logger)
        {
            Init();
        }

        public MTKTestSTC(LogManager Logger, SerialPort MTKPort, SerialPort DUTPort)
            : base(Logger, MTKPort, DUTPort)
        {
            Init();
        }

        private void Init()
        {
            TestParameterCount = 1;
            PacketCount = 1000;
        }

        public override string GetDisplayText()
        {
            return "STC: Packet Count:" + PacketCount.ToString() + " | DelayPerCommand: " + DelayPerCommand.ToString();
        }

        public override string GetTestParameter(int TestParameterIndex)
        {
            switch (TestParameterIndex)
            {
                case 0:
                    return PacketCount.ToString();
            }
            return base.GetTestParameter(TestParameterIndex);
        }

        public override string GetTestParameterName(int TestParameterIndex)
        {
            switch (TestParameterIndex)
            {
                case 0:
                    return "PacketCount";
            }
            return base.GetTestParameterName(TestParameterIndex);
        }

        public override bool SetTestParameter(int TestParameterIndex, string ParameterValue)
        {
            if (ParameterValue == "")
            {
                return false;
            }
            switch (TestParameterIndex)
            {
                case 0:
                    PacketCount = int.Parse(ParameterValue);
                    return true;
            }
            return false;
        }

        private MTKTestError RunTestBLE()
        {
            int PercentageComplete = 0;
            int DelayPerCommand = 20;
            int TimeSlice = 100;
            int TimeIncSteps = ((int)((double)PacketCount * 7.5) + 50) / TimeSlice;
            int PercentIncSteps = 1;

            MTKTestError CommandRetVal;

            

            this.Log.PrintLog(this, GetDisplayText(), LogDetailLevel.LogRelevant);

            TestStatusUpdate(MTKTestMessageType.Information, PercentageComplete.ToString() + "%");

            //  Command #1
            CommandRetVal = SearchForDUT();
            if (CommandRetVal != MTKTestError.NoError)
            {
                return CommandRetVal;
            }

            //  Command #2
            string Command = "DUT 1";
            CommandRetVal = SendCommand(MTKSerialPort, Command, DelayPerCommand);
            if (CommandRetVal != MTKTestError.NoError)
            {
                return CommandRetVal;
            }

            //  Command #3
            Command = "STC " + this.PacketCount.ToString();
            CommandRetVal = SendCommand(MTKSerialPort, Command, DelayPerCommand);
            if (CommandRetVal != MTKTestError.NoError)
            {
                return CommandRetVal;
            }

            //  Command #4
            Command = "DUT 0";
            CommandRetVal = SendCommand(MTKSerialPort, Command, DelayPerCommand);
            if (CommandRetVal != MTKTestError.NoError)
            {
                return CommandRetVal;
            }

            //  Command #5
            Command = "DCW " + ((int)((double)PacketCount * 7.5) + 50).ToString();
            CommandRetVal = SendCommand(MTKSerialPort, Command, DelayPerCommand);
            if (CommandRetVal != MTKTestError.NoError)
            {
                return CommandRetVal;
            }

            for (int i = 0; i < TimeSlice; i++)
            {
                PercentageComplete += PercentIncSteps;
                TestStatusUpdate(MTKTestMessageType.Information, PercentageComplete.ToString() + "%");
                Thread.Sleep(TimeIncSteps);
            }

            //  Command #6
            CommandRetVal = SearchForDUT();
            if (CommandRetVal != MTKTestError.NoError)
            {
                return CommandRetVal;
            }

            //  Command #7
            Command = "DUT 1";
            CommandRetVal = SendCommand(MTKSerialPort, Command, DelayPerCommand);
            if (CommandRetVal != MTKTestError.NoError)
            {
                return CommandRetVal;
            }

            //  Command #8
            Command = "PST";
            CommandRetVal = SendCommand(MTKSerialPort, Command, 200);
            if (CommandRetVal != MTKTestError.NoError)
            {
                return CommandRetVal;
            }
            if (CommandResult == "")
            {
                this.Log.PrintLog(this, Command + ": unable to find DUT.", LogDetailLevel.LogRelevant);
                TestStatusUpdate(MTKTestMessageType.Failure, "Error!!!");
                return MTKTestError.MissingDUT;
            }
            TestResult.Result = CommandResult;
            this.Log.PrintLog(this, "Time elapsed (ms): " + this.CommandResult, LogDetailLevel.LogRelevant);

            //  Command #9
            Command = "DUT 0";
            CommandRetVal = SendCommand(MTKSerialPort, Command, DelayPerCommand);
            if (CommandRetVal != MTKTestError.NoError)
            {
                return CommandRetVal;
            }

            MTKTestError RetVal = MTKTestError.NoError;

            if (Int32.Parse(CommandResult) < PacketCount)
            {
                TestStatusUpdate(MTKTestMessageType.Complete, "FAIL");
                RetVal = MTKTestError.TestFailed;
                this.Log.PrintLog(this, "Result: FAIL", LogDetailLevel.LogRelevant);
            }
            else
            {
                TestStatusUpdate(MTKTestMessageType.Complete, "PASS");
                this.Log.PrintLog(this, "Result: PASS", LogDetailLevel.LogRelevant);
            }

            return RetVal;
        }

        private MTKTestError RunTestUART()
        {
            int PercentageComplete = 0;
            int TimeSlice = 100;
            //int TimeIncSteps = ((int)((double)PacketCount * 7.5) + 50) / TimeSlice;
            int TimeIncSteps = ((int)((double)PacketCount * 0.2) + 0) / TimeSlice;
            int PercentIncSteps = 1;


            MTKTestError CommandRetVal = MTKTestError.UnknownError;
            MTKTestError RetVal = MTKTestError.UnknownError;


            this.Log.PrintLog(this, GetDisplayText(), LogDetailLevel.LogRelevant);

            TestStatusUpdate(MTKTestMessageType.Information, PercentageComplete.ToString() + "%");

            ////  Command #1
            //string Command = "RRS";
            //CommandRetVal = SendCommand(DUTSerialPort, Command, DelayPerCommand);
            //if (CommandRetVal != MTKTestError.NoError)
            //{
            //    return CommandRetVal;
            //}

            ////  Command #2
            //Command = "RRS";
            //CommandRetVal = SendCommand(MTKSerialPort, Command, DelayPerCommand);
            //if (CommandRetVal != MTKTestError.NoError)
            //{
            //    return CommandRetVal;
            //}

            //  Command #1
            string Command = "RRS";
            //Read Response 
            //no return if failure 
            //by cysp

            int loops = CyBLE_MTK_Application.Properties.Settings.Default.STCTestRRSRetryInTheBeginning;

            if (loops < 0)
            {
                loops = 0;
            }

            for (int i = 0; i < loops; i++)
            {
                CommandRetVal = SendCommand(DUTSerialPort, Command, DelayPerCommand);
                if (CommandRetVal == MTKTestError.NoError)
                {
                    break;          //break if SendCommand NoError by cysp
                }
                TestStatusUpdate(MTKTestMessageType.Information, "RRS Retry: " + (i + 1).ToString());
                this.Log.PrintLog(this, "RRS Retry: " + (i + 1).ToString() + " | DelayPerCommand: " + DelayPerCommand.ToString(), LogDetailLevel.LogRelevant);
                Thread.Sleep(100);

            }

            // end by cysp


            //ExecuteSTCCommand(Command, CommandRetVal, DUTSerialPort, DelayPerCommand, TimeSlice, TimeIncSteps, PercentageComplete, PercentIncSteps);

            //ExecuteRRSCommand(Command, CommandRetVal, DUTSerialPort, DelayPerCommand);

            //  Command #3
            Command = "STC " + (this.PacketCount).ToString();
            CommandRetVal = SendCommand(DUTSerialPort, Command, DelayPerCommand);
            if (CommandRetVal != MTKTestError.NoError)
            {
                Log.PrintLog(this, $"STC command sending on DUT ({DUTSerialPort}) failure due to {CommandRetVal}.", LogDetailLevel.LogRelevant);
                return CommandRetVal;
            }




            for (int i = 0; i < TimeSlice; i++)
            {
                PercentageComplete += PercentIncSteps;
                TestStatusUpdate(MTKTestMessageType.Information, PercentageComplete.ToString() + "%");
                Thread.Sleep(TimeIncSteps);

            }

            Thread.Sleep(400);


            //  Command #4
            Command = "RRS";
            CommandRetVal = SendCommand(DUTSerialPort, Command, DelayPerCommand);
            if (CommandRetVal != MTKTestError.NoError)
            {
                return CommandRetVal;
            }
            else if (CommandResult == "")
            {
                this.Log.PrintLog(this, Command + ": unable to find DUT.", LogDetailLevel.LogRelevant);
                TestStatusUpdate(MTKTestMessageType.Failure, "Error!!!");
                return MTKTestError.MissingDUT;
            }
            else if (int.Parse(CommandResult)>= PacketCount)
            {
                RetVal = MTKTestError.NoError;
                Log.PrintLog(this, $"STC Successful on DUT ({DUTSerialPort}): Actual received: {CommandResult} || Expected received: {PacketCount}", LogDetailLevel.LogRelevant);
            }
            else
            {
                for (int j = 1; j < 5; j++)
                {
                    TimeIncSteps = ((int)((double)PacketCount * 0.5) + 0) / TimeSlice;
                    //  Command #3
                    Command = "STC " + (this.PacketCount).ToString();
                    CommandRetVal = SendCommand(DUTSerialPort, Command, DelayPerCommand);
                    if (CommandRetVal != MTKTestError.NoError)
                    {
                        Log.PrintLog(this, $"STC command sending on DUT ({DUTSerialPort}) failure due to {CommandRetVal}.", LogDetailLevel.LogRelevant);
                        return CommandRetVal;
                    }

                    TestStatusUpdate(MTKTestMessageType.Information, $"Retry#{j}");
                    Thread.Sleep(300);

                    for (int i = 0; i < TimeSlice; i++)
                    {
                        PercentageComplete = 0;
                        PercentageComplete += PercentIncSteps;
                        TestStatusUpdate(MTKTestMessageType.Information, PercentageComplete.ToString() + "%");
                        Thread.Sleep(TimeIncSteps*j + j);
                    }

                    //  Command #4 2nd Retry
                    Command = "RRS";
                    CommandRetVal = SendCommand(DUTSerialPort, Command, DelayPerCommand);

                    if (CommandResult == "")
                    {
                        RetVal = MTKTestError.TestFailed;
                        Log.PrintLog(this, $"STC Failure on DUT ({DUTSerialPort}):  No Response from DUT", LogDetailLevel.LogRelevant);
                    }
                    else if (int.Parse(CommandResult) >= PacketCount)
                    {
                        break;
                    }
                    else
                    {
                        Log.PrintLog(this, $"STC Failure on DUT ({DUTSerialPort}): Actual received: {CommandResult} || Expected received: {PacketCount}", LogDetailLevel.LogRelevant);

                    }
                }

                if (CommandResult == "")
                {
                    RetVal = MTKTestError.TestFailed;
                    Log.PrintLog(this, $"STC Failure on DUT ({DUTSerialPort}):  No Response from DUT", LogDetailLevel.LogRelevant);
                    return RetVal;
                }
                else if (int.Parse(CommandResult) >= PacketCount)
                {
                    RetVal = MTKTestError.NoError;
                    Log.PrintLog(this, $"STC Successful on DUT ({DUTSerialPort}): Actual received: {CommandResult} || Expected received: {PacketCount}", LogDetailLevel.LogRelevant);
                }
                else
                {
                    RetVal = MTKTestError.TestFailed;
                    Log.PrintLog(this, $"STC Failure on DUT ({DUTSerialPort}): Actual received: {CommandResult} || Expected received: {PacketCount}", LogDetailLevel.LogRelevant);
                }


            }
            

            TestResult.PassCriterion = PacketCount.ToString();
            this.Log.PrintLog(this, "Expected Packet Count: " + PacketCount.ToString(), LogDetailLevel.LogEverything);
            TestResult.Measured = CommandResult;
            this.Log.PrintLog(this, "Packets transmitted: " + this.CommandResult, LogDetailLevel.LogEverything);

            if (!MTKSerialPort.IsOpen)
            {
                TestStatusUpdate(MTKTestMessageType.Information, "ERROR");
                this.Log.PrintLog(this, "Result: ERROR due to Host Serial COM port is not open", LogDetailLevel.LogRelevant);
                RetVal = MTKTestError.MissingMTKSerialPort;
                TestResult.Result = "ERROR";
            }
            else if (Regex.IsMatch(CommandResult, @"^[+-]?\d*[.]?\d*$"))
            {
                if (Int32.Parse(CommandResult) >= PacketCount)
                {
                    TestStatusUpdate(MTKTestMessageType.Success, "PASS");
                    this.Log.PrintLog(this, "Result: PASS", LogDetailLevel.LogRelevant);
                    RetVal = MTKTestError.NoError;
                    TestResult.Result = "PASS";
                }
                else
                {
                    TestStatusUpdate(MTKTestMessageType.Failure, "FAIL");
                    RetVal = MTKTestError.TestFailed;
                    TestResult.Result = "FAIL";
                    this.Log.PrintLog(this, $"Result: FAIL (Actual: {CommandResult} Expect: {PacketCount})" , LogDetailLevel.LogRelevant);
                }
            }
            else
            {
                TestStatusUpdate(MTKTestMessageType.Failure, "FAIL");
                RetVal = MTKTestError.TestFailed;
                TestResult.Result = "FAIL";
                this.Log.PrintLog(this, $"Result: FAIL ({CommandResult})", LogDetailLevel.LogRelevant);

            }

            ////  Command #5
            //Command = "RRS";
            //CommandRetVal = SendCommand(MTKSerialPort, Command, DelayPerCommand);
            //if (CommandRetVal != MTKTestError.NoError)
            //{
            //    return CommandRetVal;
            //}

            return RetVal;
        }

        private bool ExecuteRRSCommand(string command, MTKTestError commandRetVal, SerialPort dUTSerialPort, int delayPerCommand)
        {
            throw new NotImplementedException();
        }

        private bool ExecuteSTCCommand(string Command, MTKTestError CommandRetVal, SerialPort DUTSerialPort, int DelayPerCommand, int TimeSlice, int TimeIncSteps, int PercentageComplete, int PercentIncSteps)
        {
            //  Command #3
            Command = "STC " + (this.PacketCount*2).ToString();
            CommandRetVal = SendCommand(DUTSerialPort, Command, DelayPerCommand);
            if (CommandRetVal != MTKTestError.NoError)
            {
                return false;
            }



            for (int i = 0; i < TimeSlice; i++)
            {
                PercentageComplete += PercentIncSteps;
                TestStatusUpdate(MTKTestMessageType.Information, PercentageComplete.ToString() + "%");
                Thread.Sleep(TimeIncSteps);
            }

            return true;
        }

        private void RefreshMTKHostSerialPort (SerialPort MTKHostComPort)
        {
            if (MTKHostComPort.IsOpen)
            {
                MTKHostComPort.Close();
                MTKHostComPort.Open();
                Log.PrintLog(this, "MTKHostComPort has been refreshed before STC test.", LogDetailLevel.LogRelevant);
            }
            else
            {
                MTKHostComPort.Open();
                Log.PrintLog(this, "MTKHostComPort has been re-opened before STC test.", LogDetailLevel.LogRelevant);
            }


        }

        public override MTKTestError RunTest()
        {
            MTKTestError RetVal = MTKTestError.NoError;

            this.InitializeTestResult();

            if (this.DUTConnectionMode == DUTConnMode.BLE)
            {
                RetVal = RunTestBLE();
            }
            else if (this.DUTConnectionMode == DUTConnMode.UART)
            {

                RefreshMTKHostSerialPort(MTKSerialPort);

                RetVal = RunTestUART();
            }
            else
            {
                MTKTestTmplSFCSErrCode = ECCS.ERROR_CODE_CAUSED_BY_MTK_TESTER;
                return MTKTestError.NoConnectionModeSet;
            }

            TestResultUpdate(TestResult);

            if (RetVal == MTKTestError.NoError)
            {
                if (MTKSerialPort.IsOpen)
                {
                    MTKTestTmplSFCSErrCode = ECCS.ERRORCODE_ALL_PASS;
                }
                else
                {
                    MTKTestTmplSFCSErrCode = ECCS.ERROR_CODE_CAUSED_BY_MTK_TESTER;
                }
                
            }
            else if (RetVal == MTKTestError.IgnoringDUT)
            {
                MTKTestTmplSFCSErrCode = ECCS.ERRORCODE_DUT_NOT_TEST;
            }
            else
            {
                MTKTestTmplSFCSErrCode = ECCS.ERRORCODE_STC_DATA_TRANSFER_TEST_FAIL;
            }

            return RetVal;
        }

        protected override void InitializeTestResult()
        {
            base.InitializeTestResult();
            TestResult.PassCriterion = "N/A";
            TestResult.Measured = "N/A";

            CurrentMTKTestType = MTKTestType.MTKTestSTC;

            MTKTestTmplSFCSErrCode = ECCS.TMPL_ERROR_CODE;

        }
    }
}
