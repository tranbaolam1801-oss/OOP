import random
import os
import time

# Hàm tạo màu ANSI
def color_random():
    colors = [
        "\033[31m",  # đỏ
        "\033[32m",  # xanh lá
        "\033[33m",  # vàng
        "\033[34m",  # xanh dương
        "\033[35m",  # tím
        "\033[36m",  # xanh ngọc
        "\033[91m",  # đỏ sáng
        "\033[92m",  # xanh lá sáng
        "\033[93m",  # vàng sáng
        "\033[94m",  # xanh sáng
        "\033[95m",  # tím sáng
        "\033[96m",  # cyan sáng
    ]
    return random.choice(colors)

def christmas_tree(height):
    tree_lines = []

    # Tạo các dòng cây thông
    for i in range(height):
        line = " " * (height - i)
        for j in range(2 * i + 1):
            # Ngẫu nhiên đèn màu
            if random.random() < 0.15:
                line += color_random() + "@" + "\033[0m"
            else:
                line += "\033[32m" + "*" + "\033[0m"
        tree_lines.append(line)

    # Gốc cây
    trunk = " " * height + "\033[33m" + "|||\033[0m"
    tree_lines.append(trunk)
    tree_lines.append(trunk)

    return tree_lines


# 🔥 Vòng lặp để đổi màu liên tục
def animate_tree(height=10):
    while True:
        os.system('cls' if os.name == 'nt' else 'clear')
        tree = christmas_tree(height)
        for line in tree:
            print(line)
        time.sleep(0.3)    # tốc độ nhấp nháy


# Chạy chương trình
animate_tree(12)
