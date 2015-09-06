using System;
using ParserLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestParser
{
    [TestClass]
    public class UnitTestCommands
    {
        [TestMethod]
        public void TestMethod_EmptyCommand_ChekIsMatch()
        {
            // Arrange
            var command = new EmptyCommand();
            command.Params = "";

            // Act
            var result = command.IsMatch();

            // Assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestMethod_EmptyCommand_ChekIsNotMatch()
        {
            // Arrange
            var command = new EmptyCommand();
            command.Params = "frwrtg";

            // Act
            var result = command.IsMatch();

            // Assert
            Assert.AreEqual(false, result);
        }
        
        [TestMethod]
        public void TestMethod_EmptyCommand()
        {
            // Arrange
            var command = new EmptyCommand();
            command.Params = "dfgtt";

            // Act
            var result = command.DoAction();

            // Assert
            Assert.AreEqual("This is help...", result);
        }

        [TestMethod]
        public void TestMethod_HelpCommand_CheckVar1()
        {
            // Arrange
            var command = new HelpCommand();
            command.Params = HelpCommand.HelpTextVar1;

            // Act
            var result = command.IsMatch();

            // Assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestMethod_HelpCommand_CheckVar2()
        {
            // Arrange
            var command = new HelpCommand();
            command.Params = HelpCommand.HelpTextVar2;

            // Act
            var result = command.IsMatch();

            // Assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestMethod_HelpCommand_CheckVar3()
        {
            // Arrange
            var command = new HelpCommand();
            command.Params = HelpCommand.HelpTextVar3;

            // Act
            var result = command.IsMatch();

            // Assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestMethod_HelpCommand_NoFound()
        {
            // Arrange
            var command = new HelpCommand();
            command.Params = "dkrfkktk";

            // Act
            var result = command.IsMatch();

            // Assert
            Assert.AreEqual(false, result);
        }
 
        [TestMethod]
        public void TestMethod_HelpCommand()
        {
            // Arrange
            var command = new HelpCommand();
            command.Params = "dfgtt";

            // Act
            var result = command.DoAction();

            // Assert
            Assert.AreEqual("This is help...", result);
        }




        







        [TestMethod]
        public void TestMethod_ParserCommand_Check()
        {
            // Arrange
            var command = new ParserCommand();
            command.Params = "-k djdjdjk";

            // Act
            var result = command.IsMatch();

            // Assert
            Assert.AreEqual(true, result);
        }



        [TestMethod]
        public void TestMethod_ParserCommand_keyval()
        {
            // Arrange
            var command = new ParserCommand();
            command.Params = "-k key1 val1";

            // Act
            var result = command.DoAction();

            // Assert
            Assert.AreEqual("key1-val1", result);
        }

        [TestMethod]
        public void TestMethod_ParserCommand_TwoKeyval()
        {
            // Arrange
            var command = new ParserCommand();
            command.Params = "-k key1 val1 key2 val2";

            // Act
            var result = command.DoAction();

            // Assert
            Assert.AreEqual("key1-val1" + System.Environment.NewLine + "key2-val2", result);
        }

        [TestMethod]
        public void TestMethod_ParserCommand_TwoKeyvalWithNull()
        {
            // Arrange
            var command = new ParserCommand();
            command.Params = "-k key1 val1 key2";

            // Act
            var result = command.DoAction();

            // Assert
            Assert.AreEqual("key1-val1" + System.Environment.NewLine + "key2-<null>", result);
        }






        [TestMethod]
        public void TestMethod_PingCommand_Check()
        {
            // Arrange
            var command = new PingCommand();
            command.Params = "-ping";

            // Act
            var result = command.IsMatch();

            // Assert
            Assert.AreEqual(true, result);
        }


        [TestMethod]
        public void TestMethod_PingCommand()
        {
            // Arrange
            var command = new PingCommand();
            command.Params = "-ping";

            // Act
            var result = command.DoAction();

            // Assert
            Assert.AreEqual("ping...", result);
        }


        [TestMethod]
        public void TestMethod_PrintMessage_Check()
        {
            // Arrange
            var command = new PrintMessageCommand();
            command.Params = "-print";

            // Act
            var result = command.IsMatch();

            // Assert
            Assert.AreEqual(true, result);
        }


        [TestMethod]
        public void TestMethod_PrintMessage()
        {
            // Arrange
            var command = new PrintMessageCommand();
            command.Params = "-print hhghgh v fgg";

            // Act
            var result = command.DoAction();

            // Assert
            Assert.AreEqual("hhghgh v fgg", result);
        }

        [TestMethod]
        public void TestMethod_WrongCommand_Check()
        {
            // Arrange
            var command = new WrongCommand();
            command.Params = "-print1";

            // Act
            var result = command.IsMatch();

            // Assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestMethod_WrongCommand_NotCheck()//todo write for all command parse and other
        {
            // Arrange
            var command = new WrongCommand();
            command.Params = "-print";

            // Act
            var result = command.IsMatch();

            // Assert
            Assert.AreEqual(false, result);
        }


        [TestMethod]
        public void TestMethod_WrongCommandk()
        {
            // Arrange
            var command = new WrongCommand();
            command.Params = "-pringggggggt";

            // Act
            var result = command.DoAction();

            // Assert
            Assert.AreEqual("-pringggggggt", result);
        }

    }
}
