using Fight;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuffUI : MonoBehaviour
{
    [SerializeField]
    GameObject UIPrefab;
    [SerializeField]
    GameObject parent;
    [SerializeField]
    CombatEntity entity;

    Dictionary<int, Image> buffUIs;
    void Start()
    {
        buffUIs = new Dictionary<int, Image>();
        entity.buffManager.OnAddBuff += AddIcon;
        entity.buffManager.OnRemoveBuff += RemoveIcon;
    }

    private void AddIcon(BuffBase @base)
    {
        var ui = Instantiate(UIPrefab,parent.transform);
        var image = ui.GetComponent<Image>();
        image.sprite = @base.data.icon;
        buffUIs.Add(@base.data.id,image);
    }
    private void RemoveIcon(BuffBase @base)
    {
        if (buffUIs.ContainsKey(@base.data.id))
        {
            var ui = buffUIs[@base.data.id];
            Destroy(ui.gameObject);
            buffUIs.Remove(@base.data.id);
        }
    }
}
