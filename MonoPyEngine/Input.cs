using System;
using System.Collections.Generic;

public enum KeyCode
{
    A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, Q, R, S, T, U, V, W, X, Y, Z,
    Space, Enter, Escape, Backspace, Tab,
    UpArrow, DownArrow, LeftArrow, RightArrow,
    Alpha0, Alpha1, Alpha2, Alpha3, Alpha4, Alpha5, Alpha6, Alpha7, Alpha8, Alpha9,
    F1, F2, F3, F4, F5, F6, F7, F8, F9, F10, F11, F12
}

public static class Input
{
    private static HashSet<KeyCode> keysHeld = new HashSet<KeyCode>();
    private static HashSet<KeyCode> keysDown = new HashSet<KeyCode>();

    public static void Update()
    {
        keysDown.Clear();
        keysHeld.Clear();

        while (Console.KeyAvailable)
        {
            var info = Console.ReadKey(true);
            KeyCode? kc = KeyToKeyCode(info.Key);
            if (!kc.HasValue) continue;

            if (!keysHeld.Contains(kc.Value))
                keysDown.Add(kc.Value);

            keysHeld.Add(kc.Value);
        }
    }

    /// <summary>True every frame the OS is firing events for this key.</summary>
    public static bool GetKey(KeyCode key)     => keysHeld.Contains(key);

    /// <summary>True only on the first frame the key was pressed.</summary>
    public static bool GetKeyDown(KeyCode key) => keysDown.Contains(key);

    private static KeyCode? KeyToKeyCode(ConsoleKey key)
    {
        switch (key)
        {
            case ConsoleKey.A: return KeyCode.A;
            case ConsoleKey.B: return KeyCode.B;
            case ConsoleKey.C: return KeyCode.C;
            case ConsoleKey.D: return KeyCode.D;
            case ConsoleKey.E: return KeyCode.E;
            case ConsoleKey.F: return KeyCode.F;
            case ConsoleKey.G: return KeyCode.G;
            case ConsoleKey.H: return KeyCode.H;
            case ConsoleKey.I: return KeyCode.I;
            case ConsoleKey.J: return KeyCode.J;
            case ConsoleKey.K: return KeyCode.K;
            case ConsoleKey.L: return KeyCode.L;
            case ConsoleKey.M: return KeyCode.M;
            case ConsoleKey.N: return KeyCode.N;
            case ConsoleKey.O: return KeyCode.O;
            case ConsoleKey.P: return KeyCode.P;
            case ConsoleKey.Q: return KeyCode.Q;
            case ConsoleKey.R: return KeyCode.R;
            case ConsoleKey.S: return KeyCode.S;
            case ConsoleKey.T: return KeyCode.T;
            case ConsoleKey.U: return KeyCode.U;
            case ConsoleKey.V: return KeyCode.V;
            case ConsoleKey.W: return KeyCode.W;
            case ConsoleKey.X: return KeyCode.X;
            case ConsoleKey.Y: return KeyCode.Y;
            case ConsoleKey.Z: return KeyCode.Z;
            case ConsoleKey.Spacebar:   return KeyCode.Space;
            case ConsoleKey.Enter:      return KeyCode.Enter;
            case ConsoleKey.Escape:     return KeyCode.Escape;
            case ConsoleKey.Backspace:  return KeyCode.Backspace;
            case ConsoleKey.Tab:        return KeyCode.Tab;
            case ConsoleKey.UpArrow:    return KeyCode.UpArrow;
            case ConsoleKey.DownArrow:  return KeyCode.DownArrow;
            case ConsoleKey.LeftArrow:  return KeyCode.LeftArrow;
            case ConsoleKey.RightArrow: return KeyCode.RightArrow;
            case ConsoleKey.D0: return KeyCode.Alpha0;
            case ConsoleKey.D1: return KeyCode.Alpha1;
            case ConsoleKey.D2: return KeyCode.Alpha2;
            case ConsoleKey.D3: return KeyCode.Alpha3;
            case ConsoleKey.D4: return KeyCode.Alpha4;
            case ConsoleKey.D5: return KeyCode.Alpha5;
            case ConsoleKey.D6: return KeyCode.Alpha6;
            case ConsoleKey.D7: return KeyCode.Alpha7;
            case ConsoleKey.D8: return KeyCode.Alpha8;
            case ConsoleKey.D9: return KeyCode.Alpha9;
            case ConsoleKey.F1:  return KeyCode.F1;
            case ConsoleKey.F2:  return KeyCode.F2;
            case ConsoleKey.F3:  return KeyCode.F3;
            case ConsoleKey.F4:  return KeyCode.F4;
            case ConsoleKey.F5:  return KeyCode.F5;
            case ConsoleKey.F6:  return KeyCode.F6;
            case ConsoleKey.F7:  return KeyCode.F7;
            case ConsoleKey.F8:  return KeyCode.F8;
            case ConsoleKey.F9:  return KeyCode.F9;
            case ConsoleKey.F10: return KeyCode.F10;
            case ConsoleKey.F11: return KeyCode.F11;
            case ConsoleKey.F12: return KeyCode.F12;
            default: return null;
        }
    }
}
