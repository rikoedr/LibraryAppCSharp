﻿using System;

public class Book {
	public string Title { get; set; }
	public string Author { get; set; }
	public int PublicationYear { get; set; }

	public Book(string title, string author, int publicationYear) {
		this.Title = title;
		this.Author = author;
		this.PublicationYear = publicationYear;
	}
}
