## Is this plugin right for me?

If your server's `decay.scale` convar is set to `1.0` (default), then this plugin will NOT benefit you, and you can stop reading now.

If your server's `decay.scale` is set to any other value, then this plugin will benefit you. This plugin has no configuration or permissions, so simply add it to your plugins folder to install it.

## How does it work?

First of all, Tool Cupboard upkeep costs take into account the value of the `decay.scale` convar. For example, with `decay.scale 2.0`, not only will buildings decay twice as quickly without resources, but the Tool Cupboard will also consume its resources twice as quickly. Unfortunately, there is a bug where the Tool Cupboard UI does not reflect this, leading to players wondering why their base suddenly decayed after the Tool Cupboard UI previously showed that there were sufficient resources to last a while. This bug happens because the client calculations do not take into account the value of the `decay.scale` convar. This plugin works by altering the value of another convar sent to your client, in order to trick your client into calculating and displaying the correct upkeep information.

## How can I alter decay without altering upkeep costs?

If you want to increase the rate of decay while maintaing vanilla upkeep costs, a trick you can do is to increase the `decay.upkeep_period_minutes` convar by the same rate as `decay.scale` to compensate. For example, to increase `decay.scale` from `1.0` to `3.0`, also increase `decay.upkeep_period_minutes` from `1440` to `4320`. This will cause buildings to consume resources at the vanilla rate, while buildings without resources will decay at 3 times the speed.

Note: This trick does not fix the display issue, so this plugin will still benefit you.

## What about `decay.scale 0`?

This plugin is still useful with `decay.scale 0`. However, the Tool Cupboard loot panel will show as decaying if you don't have at least one of each required resource in it. If you have the minimum resources on a `decay.scale 0` server, this plugin will attempt to display 30 days of upkeep at all times.
