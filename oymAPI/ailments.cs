using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace oymAPI
{
    public static class ailments
    {
        private static string homeinteraction = "local Players = game:GetService(\"Players\")\r\nlocal Workspace = game:GetService(\"Workspace\")\r\nlocal ReplicatedStorage = game:GetService(\"ReplicatedStorage\")\r\n\r\nlocal Player = Players.LocalPlayer\r\nlocal Character = Player.Character or Player.CharacterAdded:Wait()\r\nlocal HumanoidRootPart = Character:FindFirstChild(\"HumanoidRootPart\")\r\n\r\nlocal Dirty = function(Name)  Player.Character.HumanoidRootPart.CFrame = Workspace.HouseInteriors.blueprint:FindFirstChildWhichIsA('Model'):GetModelCFrame():ToWorldSpace(CFrame.new(0, 0, -6)) for i, v in pairs(Workspace.HouseInteriors.furniture:GetChildren()) do  if v:FindFirstChildWhichIsA(\"Model\") and v:FindFirstChildWhichIsA(\"Model\").Name == \"CheapPetBathtub\" then   local String = string.split(v.Name, \"true/\")[2]   return String end end end\r\nlocal Sleepy = function(Name)  Player.Character.HumanoidRootPart.CFrame = Workspace.HouseInteriors.blueprint:FindFirstChildWhichIsA('Model'):GetModelCFrame():ToWorldSpace(CFrame.new(0, 0, -6)) for i, v in pairs(Workspace.HouseInteriors.furniture:GetChildren()) do  if v:FindFirstChildWhichIsA(\"Model\") and v:FindFirstChildWhichIsA(\"Model\").Name == \"BasicCrib\" then   local String = string.split(v.Name, \"true/\")[2]   return String end end end\r\nlocal WaterH = function(Name)  Player.Character.HumanoidRootPart.CFrame = Workspace.HouseInteriors.blueprint:FindFirstChildWhichIsA('Model'):GetModelCFrame():ToWorldSpace(CFrame.new(0, 0, -6)) for i, v in pairs(Workspace.HouseInteriors.furniture:GetChildren()) do  if v:FindFirstChildWhichIsA(\"Model\") and v:FindFirstChildWhichIsA(\"Model\").Name == \"PetWaterBowl\" then   local String = string.split(v.Name, \"true/\")[2]   return String end end end\r\nlocal FoodH = function(Name)  Player.Character.HumanoidRootPart.CFrame = Workspace.HouseInteriors.blueprint:FindFirstChildWhichIsA('Model'):GetModelCFrame():ToWorldSpace(CFrame.new(0, 0, -6)) for i, v in pairs(Workspace.HouseInteriors.furniture:GetChildren()) do  if v:FindFirstChildWhichIsA(\"Model\") and v:FindFirstChildWhichIsA(\"Model\").Name == \"PetFoodBowl\" then   local String = string.split(v.Name, \"true/\")[2]   return String end end end\r\nlocal Toilet = function(Name)  Player.Character.HumanoidRootPart.CFrame = Workspace.HouseInteriors.blueprint:FindFirstChildWhichIsA('Model'):GetModelCFrame():ToWorldSpace(CFrame.new(0, 0, -6)) for i, v in pairs(Workspace.HouseInteriors.furniture:GetChildren()) do  if v:FindFirstChildWhichIsA(\"Model\") and v:FindFirstChildWhichIsA(\"Model\").Name == \"Toilet\" then   local String = string.split(v.Name, \"true/\")[2]   return String end end end\r\n\r\n\r\n    \r\n    function ineraction(FurnitureName, TypeInteraction)\r\n     game:GetService(\"ReplicatedStorage\").API[\"HousingAPI/ActivateFurniture\"]:InvokeServer(table.unpack({  [1] = game:GetService(\"Players\").LocalPlayer,  [2] = \"\" .. FurnitureName,  [3] = \"\"..TypeInteraction,  [4] = { [\"cframe\"] = HumanoidRootPart.CFrame,   },  [5] = workspace:FindFirstChild(\"Pets\"):GetChildren()[1],}))\r\n\r\nend\r\nwait(6)";

        //  private static string external = "local Location\r\nfor i, v in pairs(getgc()) do\r\n    if type(v) == \"function\" then\r\n        local e = getfenv(v)\r\n        if e and e.script and string.find(e.script:GetFullName(), \"InteriorsM\") then\r\n            for _, c in pairs(getconstants(v)) do\r\n                if type(c) == \"string\" and string.find(c, \"SetLocation\") then\r\n                    Location = v\r\n                    break\r\n                end\r\n            end\r\n        end\r\n    end\r\n    if Location then break end\r\nend\r\n\r\nlocal function SetLocation(...)\r\n    local o = get_thread_identity()\r\n    set_thread_identity(2)\r\n    local r = {pcall(Location, ...)}\r\n    set_thread_identity(o)\r\n    return unpack(r)\r\nend\r\n\r\nlocal Neighborhood\r\nfor k, v in pairs(getfenv(0)) do\r\n    if type(v) == \"function\" and string.find(k, \"Neighbor\") then\r\n        Neighborhood = v\r\n        break\r\n    end\r\nend\r\nlocal function mainMapP()\r\n   SetLocation(\"MainMap\", \"MainDoor\", {})\r\nwait(3)\r\ngame.Players.LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-607.94,27.96,-1468.74)\r\nwait(1)\r\ngame.Players.LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-607.94,27.96,-1468.74)\r\nend\r\n\r\n\r\nlocal function School()\r\n   SetLocation(\"School\", \"MainDoor\", {})\r\nwait(3)\r\ngame.Players.LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new( -12002.91,6956.39, -3037.84)\r\nwait(1)\r\ngame.Players.LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new( -12002.91,6956.39, -3037.84)\r\nend\r\n\r\nlocal function Ballon()\r\n   SetLocation(\"MainMap\", \"MainDoor\", {})\r\nwait(3)\r\ngame.Players.LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new( -9.69,42.60,-1411.49)\r\nwait(1)\r\ngame.Players.LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-9.69,42.60,-1411.49)\r\nend\r\n\r\n\r\n\r\nlocal function PizzaShop()\r\n   SetLocation(\"PizzaShop\", \"MainDoor\", {})\r\nwait(3)\r\ngame.Players.LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(0.70,6972.51,-5941.87)\r\nwait(1)\r\ngame.Players.LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(0.70,6972.51,-5941.87)\r\nend";
        private static string finditem = "\r\nlocal Players = game:GetService(\"Players\")\r\nlocal ReplicatedStorage = game:GetService(\"ReplicatedStorage\")\r\nlocal LocalPlayer = Players.LocalPlayer\r\n\r\n\r\n\r\nlocal function FindQuestItem(name)\r\n    local inventory = require(ReplicatedStorage:FindFirstChild(\"ClientModules\"):FindFirstChild(\"Core\").ClientData).get_data()[LocalPlayer.Name].inventory\r\n    if not inventory then\r\n       \r\n        return {}\r\n    end\r\n    \r\n    local itemID = {}\r\n   local itemTypes = {\"gifts\", \"transport\" , \"toys\", \"food\", \"pet_accessories\", \"strollers\"}\r\n   \r\n    \r\n    for _, itemType in ipairs(itemTypes) do\r\n        local items = inventory[itemType]\r\n        if items then\r\n            for i, v in pairs(items) do\r\n                if v and v.kind:match(name)   then\r\n                    local itemName = v.name or v.displayName or v.Name or tostring(i)\r\n                  \r\n                    table.insert(itemID, {\r\n                        id = i,\r\n                        type = itemType,\r\n                        data = v,\r\n                        name = itemName,\r\n                        kind = v.kind,\r\n                        uniqueId = v.kind .. \"_\" .. itemType\r\n                    })\r\n                end\r\n            end\r\n        end\r\n    end\r\n    \r\n   \r\n    return itemID\r\nend\r\n\r\n\r\nlocal itemIDS \r\n\r\nlocal function GETQuestItem(name)\r\nlocal itemID = FindQuestItem(name)\r\n    if #itemID > 0  then\r\n        \r\n          \r\n        itemIDS=  itemID[1].id\r\n       return itemIDS\r\n    end \r\n    end";
        public static string getExecute(string json, string petID)
        {

            using JsonDocument doc = JsonDocument.Parse(json);
            JsonElement root = doc.RootElement;
            string execute = homeinteraction;// +"\r\n"+finditem;
            foreach (JsonProperty PetAilments in root.GetProperty("ailments").EnumerateObject())
            {
                if (PetAilments.Name == petID)
                {
                   // execute += $"game:GetService(\"ReplicatedStorage\").API[\"IdleProgressionAPI/CommitAllProgression\"]:FireServer(true)";
                    foreach (JsonProperty state2 in root.GetProperty("ailments").GetProperty(PetAilments.Name).EnumerateObject())
                    {
                      //Console.WriteLine("print(\"" + state2.Name + "\")");

                        if (state2.Name == "sleepy")
                        {
                            execute += "ineraction(Sleepy(),\"UseBlock\") wait(20)\r\n";
                        }
                        if (state2.Name == "dirty")
                        {
                            execute += "ineraction(Dirty(),\"UseBlock\") wait(20)\r\n";
                        }
                        if (state2.Name == "hungry")
                        {
                            execute += "ineraction(FoodH(),\"UseBlock\") wait(20)\r\n";
                        }
                        if (state2.Name == "thirsty")
                        {
                            execute += "ineraction(WaterH(),\"UseBlock\") wait(20)\r\n";
                        }
                        if (state2.Name == "toilet")
                        {
                            execute += "ineraction(Toilet(),\"Seat1\") wait(20)\r\n";
                        }
                       


                        if (state2.Name == "play")
                        {
                            execute += finditem + " \r\n  for i = 1, 4 do\r\n     print(GETQuestItem(\"bone\"))\r\n      game:GetService(\"ReplicatedStorage\").API[\"PetObjectAPI/CreatePetObject\"]:InvokeServer(table.unpack({\r\n    [1] = \"__Enum_PetObjectCreatorType_1\",\r\n    [2] = {\r\n        [\"reaction_name\"] = \"ThrowToyReaction\",\r\n        [\"unique_id\"] = GETQuestItem(\"bone\"),\r\n    },\r\n}))\r\n wait(5)\r\nend";
                        }
                        if (state2.Name == "sick")
                        {
                            execute += finditem + "\r\ngame:GetService(\"ReplicatedStorage\").API[\"ShopAPI/BuyItem\"]:InvokeServer(table.unpack({\r\n    [1] = \"food\",\r\n    [2] = \"healing_apple\",\r\n    [3] = {\r\n        [\"buy_count\"] = 1,\r\n    },\r\n})) game:GetService(\"ReplicatedStorage\").API[\"PetObjectAPI/CreatePetObject\"]:InvokeServer(table.unpack({\r\n    [1] = \"__Enum_PetObjectCreatorType_2\",\r\n    [2] = {\r\n        [\"pet_unique\"] = \""+petID+ "\",\r\n        [\"additional_consume_uniques\"] = {\r\n        },\r\n        [\"unique_id\"] =  GETQuestItem(\"healing_apple\"),\r\n    },\r\n}))";
                        }
                        if (state2.Name == "pet_me")
                        {
                            execute += "\r\n wait(10) game:GetService(\"ReplicatedStorage\").API[\"PetAPI/ReplicateActivePerformances\"]:FireServer(table.unpack({\r\n    workspace.Pets:GetChildren()[1],\r\n    [2] = {\r\n        [\"FocusPet\"] = true,\r\n    },\r\n}))\r\ngame:GetService(\"ReplicatedStorage\").API[\"PetAPI/PetPetted\"]:FireServer(table.unpack({\r\n    [1] = \"" + petID + "\",\r\n    [2] = game:GetService(\"Players\").LocalPlayer,\r\n})) \r\ngame:GetService(\"ReplicatedStorage\").API[\"AilmentsAPI/ProgressPetMeAilment\"]:FireServer(\"" + petID + "\")\r\n  wait(2) game:GetService(\"ReplicatedStorage\").API[\"PetAPI/ReplicateActivePerformances\"]:FireServer(table.unpack({\r\n    workspace.Pets:GetChildren()[1],\r\n    [2] = {\r\n        [\"FocusPet\"] = true,\r\n    },\r\n}))\r\ngame:GetService(\"ReplicatedStorage\").API[\"PetAPI/PetPetted\"]:FireServer(table.unpack({\r\n    [1] = \"" + petID + "\",\r\n    [2] = game:GetService(\"Players\").LocalPlayer,\r\n})) \r\ngame:GetService(\"ReplicatedStorage\").API[\"AilmentsAPI/ProgressPetMeAilment\"]:FireServer(\"" + petID + "\")\r\n  print(\"triggered\") wait(20)";

                        }


                        //if (state2.Name == "school")
                        //{
                        //    execute += external + "\r\n school()";
                        //}
                    }
                }
            }
         
            //string path = "C:\\AD\\OSPanel\\home\\example.local\\note1.txt";
            //using StreamWriter writer = new StreamWriter(path, append: false);
            //writer.WriteLineAsync(execute);
            return execute;
        }
    }
}
