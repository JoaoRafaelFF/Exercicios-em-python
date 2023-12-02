# -*- coding: latin1 -*-
import sqlite3
# Connect to the SQLite database or create it if it doesn't exist
con = sqlite3.connect('database.db')

# Create a cursor object
cur = con.cursor()

# Create the table if it doesn't exist
cur.execute('''CREATE TABLE IF NOT EXISTS users
                 (name TEXT, address TEXT, weight REAL, height REAL, imc REAL)''')

# Insert the data into the table
name = raw_input("Nome: ")
address = raw_input("Endereco: ")
weight = float(raw_input("Peso: "))
height = float(raw_input("Altura: "))

imc = weight / (height ** 2)

cur.execute("INSERT INTO users (name, address, weight, height, imc) VALUES (?, ?, ?, ?, ?)",
            (name, address, weight, height, imc))

# Commit the changes and close the connection
con.commit()
con.close()