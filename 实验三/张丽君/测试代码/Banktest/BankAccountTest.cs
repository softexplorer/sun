using BankAccountNS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Banktest
{
    
    
    /// <summary>
    ///这是 BankAccountTest 的测试类，旨在
    ///包含所有 BankAccountTest 单元测试
    ///</summary>
    [TestClass()]
    public class BankAccountTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///获取或设置测试上下文，上下文提供
        ///有关当前测试运行及其功能的信息。
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region 附加测试特性
        // 
        //编写测试时，还可使用以下特性:
        //
        //使用 ClassInitialize 在运行类中的第一个测试前先运行代码
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //使用 ClassCleanup 在运行完类中的所有测试后再运行代码
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //使用 TestInitialize 在运行每个测试前先运行代码
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //使用 TestCleanup 在运行完每个测试后运行代码
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///Credit 的测试
        ///</summary>
        [TestMethod()]
        public void CreditTest()
        {    
            double BeginBalance=10.23;
            double CreditText=7.99;
            double expect=18.22;
            BankAccount target = new BankAccount("Miss Chen",BeginBalance); // TODO: 初始化为适当的值
            target.Credit(CreditText);
            double actual = target.Balance;
            Assert.AreEqual(actual, expect);
        }

        /// <summary>
        ///BankAccount 构造函数 的测试
        ///</summary>
        [TestMethod()]
        public void BankAccountConstructorTest()
        {
            string customerName = string.Empty; // TODO: 初始化为适当的值
            double balance = 0F; // TODO: 初始化为适当的值
            BankAccount target = new BankAccount(customerName, balance);
        }

        /// <summary>
        ///BankAccount 构造函数 的测试
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Bank.dll")]
        public void BankAccountConstructorTest1()
        {
            BankAccount_Accessor target = new BankAccount_Accessor();
          
        }

      

        /// <summary>
        ///FreezeAccount 的测试
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Bank.dll")]
        public void FreezeAccountTest()
        {
            BankAccount_Accessor target = new BankAccount_Accessor(); // TODO: 初始化为适当的值
            target.FreezeAccount();
        }

        /// <summary>
        ///Main 的测试
        ///</summary>
        [TestMethod()]
        public void MainTest()
        {
            BankAccount.Main();
          
        }

        /// <summary>
        ///UnfreezeAccount 的测试
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Bank.dll")]
        public void UnfreezeAccountTest()
        {
            BankAccount_Accessor target = new BankAccount_Accessor(); // TODO: 初始化为适当的值
            target.UnfreezeAccount();
        }

        /// <summary>
        ///Debit 的测试
        ///</summary>
        [TestMethod()]
        public void DebitTest()
        {
            double BeginBanlance = 10.21;
            double DebitText = 2.23;
            double expect = 7.98;
            BankAccount target = new BankAccount("Miss Chen",BeginBanlance); // TODO: 初始化为适当的值
           target.Debit(DebitText);
           double actual = target.Balance;
            Assert.AreEqual(actual,expect);
        }
    }
}
