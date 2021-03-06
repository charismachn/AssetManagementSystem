﻿using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SystemAsset.Domain.BizDac;
using SystemAsset.Domain.Entities;

namespace SystemAsset.WebUI.Tests.BizDac
{
    /// <summary>
    /// UserDac_UnitTest의 요약 설명
    /// </summary>
    [TestClass]
    public class UserDac_UnitTest
    {
        public UserDac_UnitTest()
        {
            //
            // TODO: 여기에 생성자 논리를 추가합니다.
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///현재 테스트 실행에 대한 정보 및 기능을
        ///제공하는 테스트 컨텍스트를 가져오거나 설정합니다.
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

        #region 추가 테스트 특성
        //
        // 테스트를 작성할 때 다음 추가 특성을 사용할 수 있습니다.
        //
        // ClassInitialize를 사용하여 클래스의 첫 번째 테스트를 실행하기 전에 코드를 실행합니다.
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // ClassCleanup을 사용하여 클래스의 테스트를 모두 실행한 후에 코드를 실행합니다.
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // TestInitialize를 사용하여 각 테스트를 실행하기 전에 코드를 실행합니다.
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // TestCleanup을 사용하여 각 테스트를 실행하기 전에 코드를 실행합니다.
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void InsertUser()
        {
            UserDac dac = new UserDac();
            UserT user = new UserT();

            string userLoginID = "testuser_" + new Random().Next(1000000, 9999999);
            user.LoginId = userLoginID;
            user.InsertUser = userLoginID;

            dac.InsertUser(user);

            UserT newUser = dac.SelectUserByLoginId(userLoginID);

            Assert.AreEqual(user.LoginId, newUser.LoginId);
        }
    }
}
