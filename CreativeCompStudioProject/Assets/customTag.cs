using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class customTag : MonoBehaviour
{
    [SerializeField]
    private List<string> tags = new List<string>();

    public bool hasTag(string tag) {
        return tags.Contains(tag);
    }

    public IEnumerable<string> getTags() {
        return tags;
    }

    public void rename(int index, string tagName) {
        tags[index] = tagName;
    }

    public string getAtIndex(int index) {
        return tags[index];
    }

    public int count() {
        return tags.Count;
    }
}
