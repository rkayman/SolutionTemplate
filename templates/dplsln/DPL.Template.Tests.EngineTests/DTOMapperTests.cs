﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using DPL.Template.Engines.Shared;

namespace DPL.Template.Tests.EngineTests
{
    [TestClass]
    public class DTOMapperTests
    {
        [TestMethod]
        [TestCategory("Engine Tests")]
        public void DTOMapper_IsDTOMApperConfigValid()
        {
            DTOMapper.Configuration.AssertConfigurationIsValid();
        }
    }
}
