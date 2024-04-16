using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public static class Locator
{
    public static EventManager event_manager = new EventManager();
    public static VFXFactory vfx_factory = null;
    public static Player player = null;
    public static CsvParser csv_parser = new CsvParser();
    public static IItemPool item_pool = new ItemPool();
    public static IItemFactory item_factory = new ItemFactory(item_pool.get_infos());
    public static IItemManager item_manager = new ItemManager();
    public static LevelManager level_manager = null;
}