﻿namespace QuestPDF.Infrastructure
{
    internal interface IStateResettable
    {
        void ResetState(bool hardReset = true);
    }
}