﻿namespace DesignPatterns.Creational.AbstractFactory.OSX
{
    public class GUIFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new Button();
        }

        public IContextMenu CreateContextMenu()
        {
            return new ContextMenu();
        }

        public IWindow CreateWindow()
        {
            return new Window();
        }
    }
}
