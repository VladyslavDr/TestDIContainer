﻿using TestDIContainer.Loggers;

namespace TestDIContainer
{
    public class Controller
    {
        private readonly IService _service;

        public Controller(IService service)
        {
            _service = service;
        }

        public void Method()
        {
            _service.Method();
        }
    }
}