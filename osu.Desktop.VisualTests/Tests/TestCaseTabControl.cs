﻿// Copyright (c) 2007-2017 ppy Pty Ltd <contact@ppy.sh>.
// Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu/master/LICENCE

using OpenTK;
using osu.Framework.Graphics.Primitives;
using osu.Framework.Screens.Testing;
using osu.Game.Graphics.Sprites;
using osu.Game.Graphics.UserInterface;
using osu.Game.Screens.Select.Filter;

namespace osu.Desktop.VisualTests.Tests
{
    public class TestCaseTabControl : TestCase
    {
        public override string Description => @"Filter for song select";

        public override void Reset()
        {
            base.Reset();

            OsuSpriteText text;
            OsuTabControl<GroupMode> filter;
            Add(filter = new OsuTabControl<GroupMode>
            {
                Width = 229,
                AutoSort = true
            });
            Add(text = new OsuSpriteText
            {
                Text = "None",
                Margin = new MarginPadding(4),
                Position = new Vector2(275, 5)
            });

            filter.PinTab(GroupMode.All);
            filter.PinTab(GroupMode.RecentlyPlayed);

            filter.ValueChanged += (sender, mode) =>
            {
                text.Text = "Currently Selected: " + mode.ToString();
            };
        }
    }
}
