using System;
using System.Collections.Generic;
using CitizenFX.Core;
using static CitizenFX.Core.Native.API;

namespace server
{
    public class Main : BaseScript
    {
        [Command("gooc")]
        public void GoocCommand(int source, List<object> args, string raw)
        {
            if (args.Count > 0)
            {
                var name = GetPlayerName(source.ToString());
                string text = String.Join(" ", args);

                TriggerClientEvent("chat:addMessage", new
                {
                    color = new[] { 255, 0, 0 },
                    multiline = true,
                    args = new[] { $"^6[GOOC] {name}: ^7{text}" }
                });


            }
        }
        [Command("vpn")]
        public void VPNCommand(int source, List<object> args, string raw)
        {
            if (args.Count > 0)
            {
                string text = String.Join(" ", args);

                TriggerClientEvent("chat:addMessage", new
                {
                    color = new[] { 255, 0, 0 },
                    multiline = true,
                    args = new[] { $"^9[VPN]: ^7{text}" }
                });


            }
        }

        [Command("twt")]
        public void TwtCommand(int source, List<object> args, string raw)
        {
            if (args.Count > 0)
            {

                string text = String.Join(" ", args);
                var name = GetPlayerName(source.ToString());

                TriggerClientEvent("chat:addMessage", new
                {
                    color = new[] { 255, 0, 0 },
                    multiline = true,
                    args = new[] { $"^5[Twitter]: ^5(@{name}^7): ^7{text}" }
                });


            }
        }
        [Command("gme")]
        public void GmeCommand(int source, List<object> args, string raw)
        {
            if (args.Count > 0)
            {

                string text = String.Join(" ", args);
                var name = GetPlayerName(source.ToString());

                TriggerClientEvent("chat:addMessage", new
                {
                    color = new[] { 255, 0, 0 },
                    multiline = true,
                    args = new[] { $"^3[Global Me]:{name} ^7{text}" }
                });


            }
        }


        [Command("leo")]
        public void LEOCommand(int source, List<object> args, string raw)
        {
            var player = Players[source];

            if (IsPlayerAceAllowed(player.Handle, "Viper.LeoChat"))
            {
                if (args.Count > 0)
                {
                    var name = GetPlayerName(player.Handle);
                    string text = String.Join(" ", args);

                    foreach (Player p in Players)
                    {
                        if (IsPlayerAceAllowed(p.Handle, "Viper.LeoChat"))
                        {
                            TriggerClientEvent(p, "chat:addMessage", new
                            {
                                color = new[] { 255, 0, 0 },
                                multiline = true,
                                args = new[] { $"^4[LEO] {name}: ^7{text}" }
                            });

                        }
                    }

                }

            }
        }
    }
}