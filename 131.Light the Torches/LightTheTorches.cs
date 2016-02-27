using System;

class LightTheTorches
{
    static bool[] basement;

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string readLine = Console.ReadLine();

        basement = UpdateTheBasementState(readLine, n);
        int currentRoomPos = n / 2;

        while (true)
        {
            readLine = Console.ReadLine();

            if (readLine == "END")
            {
                break;
            }
            else
            {
                string[] command = readLine.Split();
                string direction = command[0];
                int roomsPass = int.Parse(command[1]) + 1;
                int previouseRoomPos = currentRoomPos;

                if (direction == "LEFT")
                {
                    if (currentRoomPos - roomsPass < 0)
                    {
                        currentRoomPos = 0;
                        if (currentRoomPos != previouseRoomPos)
                        {
                            UpdateRoomState(currentRoomPos);
                        }
                    }
                    else
                    {
                        currentRoomPos -= roomsPass;
                        if (currentRoomPos != previouseRoomPos)
                        {
                            UpdateRoomState(currentRoomPos);
                        }
                    }
                }
                else // direction == right
                {
                    if (currentRoomPos + roomsPass > n - 1)
                    {
                        currentRoomPos = n - 1;
                        if (currentRoomPos != previouseRoomPos)
                        {
                            UpdateRoomState(currentRoomPos);
                        }
                    }
                    else
                    {
                        currentRoomPos += roomsPass;
                        if (currentRoomPos != previouseRoomPos)
                        {
                            UpdateRoomState(currentRoomPos);
                        }
                    }
                }
            }
        }

        int count = 0;
        for (int i = 0; i < basement.Length; i++)
        {
            if (!basement[i])
            {
                count++;
            }
        }

        Console.WriteLine(count * 68);
    }

    static void UpdateRoomState(int currentRoomPos)
    {
        if (basement[currentRoomPos] == false)
        {
            basement[currentRoomPos] = true;
        }
        else
        {
            basement[currentRoomPos] = false;
        }
    }

    static bool[] UpdateTheBasementState(string roomStates, int totalRooms)
    {
        bool[] basement = new bool[totalRooms];

        for (int i = 0; i < basement.Length; i++)
        {
            int roomStateIndex = i % roomStates.Length;

            if (roomStates[roomStateIndex] == 'L')
            {
                basement[i] = true;
            }
        }

        return basement;
    }
}
