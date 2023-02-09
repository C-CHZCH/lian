﻿// See https://aka.ms/new-console-template for more information
//leetcode 1797 验证码校验与有效时间的延长 标准答案
public class AuthenticationManager {
    int timeToLive;
    Node head;
    Node tail;
    IDictionary<String, Node> dictionary;

    public AuthenticationManager(int timeToLive) {
        this.timeToLive = timeToLive;
        this.head = new Node(-1);
        this.tail = new Node(-1);
        this.head.next = this.tail;
        this.tail.prev = this.head;
        this.dictionary = new Dictionary<String, Node>();
    }

    public void Generate(string tokenId, int currentTime) {
        Node node = new Node(currentTime + timeToLive, tokenId);
        if (!dictionary.ContainsKey(tokenId)) {
            dictionary.Add(tokenId, node);
        } else {
            dictionary[tokenId] = node;
        }
        Node last = tail.prev;
        last.next = node;
        node.prev = last;
        tail.prev = node;
        node.next = tail;
    }

    public void Renew(string tokenId, int currentTime) {//保证链表中最终过期时间是递增的
        if (dictionary.ContainsKey(tokenId) && dictionary[tokenId].expire > currentTime) {
            Node node = dictionary[tokenId];
            Node prev = node.prev;
            Node next = node.next;
            prev.next = next;
            next.prev = prev;
            node.expire = currentTime + timeToLive;
            Node last = tail.prev;
            last.next = node;
            node.prev = last;
            tail.prev = node;
            node.next = tail;
        }
    }

    public int CountUnexpiredTokens(int currentTime) {
        while (head.next.expire > 0 && head.next.expire <= currentTime) {
            Node node = head.next;
            dictionary.Remove(node.key);
            head.next = node.next;
            node.next.prev = head;
        }
        return dictionary.Count;
    }
}

class Node {
    public int expire;
    public string key;
    public Node prev;
    public Node next;

    public Node(int expire) : this(expire, null, null, null) {

    }

    public Node(int expire, string key) : this(expire, key, null, null) {

    }

    public Node(int expire, string key, Node prev, Node next) {
        this.expire = expire;
        this.key = key;
        this.prev = prev;
        this.next = next;
    }
}